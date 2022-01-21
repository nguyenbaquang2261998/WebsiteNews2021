using DOLPHIN.Caching.Interfaces;
//using DVG.AutoPortal.InfrastructureLayer.Caching.Interfaces;
//using DVG.AutoPortal.InfrastructureLayer.Serialization;
//using DVG.AutoPortal.InfrastructureLayer.Utility;
using Microsoft.AspNetCore.Http;
//using NLog;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace DVG.AutoPortal.InfrastructureLayer.Caching
{
    public class RedisCached : ICached, IQueueAndListCached
    {
        //private IDatabase client;
        private ConnectionMultiplexer _connectionMultiplexer;
        private ConnectionMultiplexer _connectionMultiplexerForWrite;

        private readonly ConfigurationOptions _config;
        private readonly int _maxLengOfValueForMonitor = AppSettings.Get("Cache:Redis:MaxLengOfValueForMonitor", 10000);
        private readonly RedisInstanceConfiguration _configuration;
        private readonly NLog.ILogger Logger = LogManager.GetCurrentClassLogger();
        
        public RedisCached()
        {
            _configuration = AppSettings.Get<RedisInstanceConfiguration>("Cache:Redis:Data");
        }
        /// <summary>
        ///     Initials Redis caching with configuration
        /// </summary>
        /// <exception cref="Configuration not allow null"></exception>
        /// <exception cref="Server's IP is undefined"></exception>
        /// <exception cref="Server's Port is undefined"></exception>
        /// <param name="configuration"></param>
        public RedisCached(RedisInstanceConfiguration configuration)
        {
            if (configuration.Timeout > 0)
                configuration.Timeout = configuration.Timeout;

            _configuration = configuration;
            _config = new ConfigurationOptions
            {
                EndPoints = { { _configuration.Server, _configuration.Port } },
                DefaultDatabase = _configuration.Database,
                ConnectTimeout = _configuration.Timeout,
                AsyncTimeout = _configuration.Timeout,
                ClientName = _configuration.Name,
                AbortOnConnectFail = false,
                ConnectRetry = 3,
                KeepAlive = 20
            };

        }

        #region Sync

        private IDatabase CreateInstanceRead()
        {
            IDatabase client = null;

            try
            {
                if (_connectionMultiplexer == null)
                {
                    var config = new ConfigurationOptions
                    {
                        EndPoints = { { _configuration.Server, _configuration.Port } },
                        DefaultDatabase = _configuration.Database,
                        ConnectTimeout = _configuration.Timeout,
                        AsyncTimeout = _configuration.Timeout,
                        ClientName = _configuration.Name,
                        AbortOnConnectFail = false,
                        ConnectRetry = 3,
                        KeepAlive = 20
                    };

                    //_connectionMultiplexer = ConnectionMultiplexer.Connect(config);
                    _connectionMultiplexer = new Lazy<ConnectionMultiplexer>(() => ConnectionMultiplexer.Connect(config)).Value;
                }

                client = _connectionMultiplexer.GetDatabase(_configuration.Database);
            }
            catch (Exception ex)
            {

                Logger.Error(ex, ex.Message);
            }

            return client;
        }

        private IDatabase CreateInstanceForWrite()
        {
            IDatabase client = null;

            try
            {
                if (_connectionMultiplexerForWrite == null)
                {
                    var config = new ConfigurationOptions
                    {
                        EndPoints = { { _configuration.Server, _configuration.Port } },
                        DefaultDatabase = _configuration.Database,
                        ConnectTimeout = _configuration.Timeout,
                        AsyncTimeout = _configuration.Timeout,
                        ClientName = _configuration.Name,
                        AbortOnConnectFail = false,
                        ConnectRetry = 3,
                        KeepAlive = 20
                    };

                    //_connectionMultiplexerForWrite = ConnectionMultiplexer.Connect(config);
                    _connectionMultiplexerForWrite = new Lazy<ConnectionMultiplexer>(() => ConnectionMultiplexer.Connect(config)).Value;
                }

                client = _connectionMultiplexerForWrite.GetDatabase(_configuration.Database);
            }
            catch (Exception ex)
            {
                Logger.Error(ex, ex.Message);
            }

            return client;
        }

        public bool Set<T>(string key, T item, int expireInMinute = 0)
        {
            var result = false;

            try
            {
                var client = CreateInstanceForWrite();

                var bytes = ZipToBytes(item, key);

                var currentTime = DateTime.Now;
                var expired = currentTime.AddMinutes(expireInMinute) - currentTime;

                if (expireInMinute > 0)
                    result = client.StringSet(key, bytes, expired);
                else
                    result = client.StringSet(key, bytes);

                return result;
            }
            catch (Exception ex)
            {
                Logger.Error(ex, ex.Message);
                return false;
            }
        }

        public T Get<T>(string key, HttpContext context = null)
        {
            var result = default(T);
            try
            {
                var client = CreateInstanceRead();

                if (CacheHelpers.IsRequestClearCache(context)) client.KeyDelete(key);

                byte[] redisValue = client.StringGet(key);

                result = UnZipFromBytes<T>(redisValue);
            }
            catch (Exception ex)
            {
                Logger.Error(ex, ex.Message);
            }

            return result;
        }

        public bool Remove(string key)
        {
            var result = false;

            try
            {
                var client = CreateInstanceForWrite();

                result = client.KeyDelete(key);
            }
            catch (Exception ex)
            {
                Logger.Error(ex, ex.Message);
            }

            return result;
        }

        public void EndQueue(string key, string item, long score)
        {
            try
            {
                var client = CreateInstanceRead();

                client.SortedSetAdd(key, item, score);
            }
            catch (Exception ex)
            {
                Logger.Error(ex, ex.Message);
            }
        }

        public string DeQueue(string key)
        {
            try
            {
                var client = CreateInstanceRead();

                var valueFromSortedSet = client.ListRightPop(key);

                return valueFromSortedSet;
            }
            catch (Exception ex)
            {
                Logger.Error(ex, ex.Message);

                return string.Empty;
            }
        }

        public void EndQueue<T>(string key, T item, long score)
        {
            try
            {
                if (score <= 0) score = Utils.DateTimeToUnixTime(DvgDateTime.Now);
                var value = NewtonJson.Serialize(item);

                EndQueue(key, value, score);
            }
            catch (Exception ex)
            {
                Logger.Error(ex, ex.Message);
            }
        }

        public T DeQueue<T>(string key)
        {
            try
            {
                var value = DeQueue(key);
                if (!string.IsNullOrEmpty(value)) return NewtonJson.Deserialize<T>(value);
            }
            catch (Exception ex)
            {
                Logger.Error(ex, ex.Message);
            }

            return default;
        }

        public long GetSortedSetCount(string key)
        {
            try
            {
                var client = CreateInstanceRead();

                return client.SortedSetLength(key);
            }
            catch (Exception ex)
            {
                Logger.Error(ex, ex.Message);
                return 0L;
            }
        }

        public void Push(string key, string item)
        {
            try
            {
                var client = CreateInstanceRead();

                client.ListLeftPush(key, item);
            }
            catch (Exception ex)
            {
                Logger.Error(ex, ex.Message);
            }
        }

        public string Pop(string key)
        {
            try
            {
                var client = CreateInstanceRead();

                return client.ListRightPop(key);
            }
            catch (Exception ex)
            {
                Logger.Error(ex, ex.Message);

                return string.Empty;
            }
        }


        public long SetEntryOrIncrementValueInHash(string hashKey, string key)
        {
            try
            {
                var client = CreateInstanceRead();

                return client.HashIncrement(key, hashKey);
            }
            catch (Exception ex)
            {
                Logger.Error(ex, ex.Message);
            }
            return 0;
        }

        public List<string> GetAllEntriesAndRemoveFromHash(string hashkey)
        {
            var outputDictsValue = new List<string>();
            try
            {
                Console.WriteLine("hashEntries hashkey:" + hashkey);

                var client = CreateInstanceRead();
                var hashEntries = client.ListRange(hashkey);
                if (hashEntries == null)
                    Console.WriteLine("hashEntries Length: is null");
                if (hashEntries != null && hashEntries.Length > 0)
                {
                    Console.WriteLine("hashEntries Length: ");
                    foreach (var item in hashEntries)
                    {
                        outputDictsValue.Add(item);
                        client.ListRightPop(hashkey);
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.Error(ex, ex.Message);
                Console.WriteLine("co loi :" + ex);
            }

            return outputDictsValue;
        }

        public void Close()
        {
            if (_connectionMultiplexer != null && _connectionMultiplexer.IsConnected) _connectionMultiplexer.Close();
            Console.WriteLine("Redis Closed");
        }

        public List<T> DeQueueList<T>(string key)
        {
            throw new NotImplementedException();
        }

        public List<T> GetAllItemsFromQueue<T>(string key)
        {
            throw new NotImplementedException();
        }

        #endregion Sync

        #region Async

        private async Task<IDatabase> CreateInstanceAsyncRead()
        {
            IDatabase client = null;
            try
            {
                if (_connectionMultiplexer == null)
                {
                    var config = new ConfigurationOptions
                    {
                        EndPoints = { { _configuration.Server, _configuration.Port } },
                        DefaultDatabase = _configuration.Database,
                        ConnectTimeout = _configuration.Timeout,
                        AsyncTimeout = _configuration.Timeout
                    };

                    _connectionMultiplexer = await ConnectionMultiplexer.ConnectAsync(config);
                }

                client = _connectionMultiplexer.GetDatabase(_configuration.Database);
            }
            catch (Exception ex)
            {
                Logger.Error(ex, ex.Message);
            }

            return client;
        }

        private async Task<IDatabase> CreateInstanceAsyncForWrite()
        {
            IDatabase client = null;
            try
            {
                if (_connectionMultiplexerForWrite == null)
                {
                    var config = new ConfigurationOptions
                    {
                        EndPoints = { { _configuration.Server, _configuration.Port } },
                        DefaultDatabase = _configuration.Database,
                        ConnectTimeout = _configuration.Timeout,
                        AsyncTimeout = _configuration.Timeout
                    };

                    _connectionMultiplexerForWrite = await ConnectionMultiplexer.ConnectAsync(config);
                }

                client = _connectionMultiplexerForWrite.GetDatabase(_configuration.Database);
            }
            catch (Exception ex)
            {
                Logger.Error(ex, ex.Message);
            }

            return client;
        }

        public async Task<bool> SetAsync<T>(string key, T item, int expireInMinute = 0)
        {
            var result = false;

            try
            {
                RedisKey redisKey = key;
                RedisValue redisValue = ZipToBytes(item, key);

                var currentTime = DateTime.Now;
                var expired = currentTime.AddMinutes(expireInMinute) - currentTime;

                var client = await CreateInstanceAsyncForWrite();

                if (expireInMinute > 0)
                    result = await client.StringSetAsync(redisKey, redisValue, expired);
                else
                    result = await client.StringSetAsync(redisKey, redisValue);

                return result;
            }
            catch (Exception ex)
            {
                Logger.Error(ex, ex.Message);
                return false;
            }
        }

        public async Task<bool> SetAsync(string key, string item, int expireInMinute = 0)
        {
            var result = false;

            try
            {
                RedisKey redisKey = key;
                RedisValue redisValue = Zip(item, key);

                var currentTime = DateTime.Now;
                var expired = currentTime.AddMinutes(expireInMinute) - currentTime;

                var client = await CreateInstanceAsyncForWrite();

                if (expireInMinute > 0)
                    result = await client.StringSetAsync(redisKey, redisValue, expired);
                else
                    result = await client.StringSetAsync(redisKey, redisValue);

                return result;
            }
            catch (Exception ex)
            {
                Logger.Error(ex, ex.Message);
                return false;
            }
        }

        public async Task<T> GetAsync<T>(string key, HttpContext context = null)
        {
            var result = default(T);
            try
            {
                var client = await CreateInstanceAsyncRead();

                if (CacheHelpers.IsRequestClearCache(context)) client.KeyDelete(key);

                byte[] bytes = await client.StringGetAsync(key);

                result = UnZipFromBytes<T>(bytes);
            }
            catch (Exception ex)
            {
                Logger.Error(ex, ex.Message);
            }

            return result;
        }

        public async Task<string> GetAsync(string key, HttpContext context = null)
        {
            var result = string.Empty;
            try
            {
                var client = await CreateInstanceAsyncRead();

                if (CacheHelpers.IsRequestClearCache(context)) client.KeyDelete(key);

                byte[] bytes = await client.StringGetAsync(key);

                result = bytes == null ? null : Unzip(bytes);
            }
            catch (Exception ex)
            {
                Logger.Error(ex, ex.Message);
            }

            return result;
        }

        public async Task<bool> RemoveAsync(string key)
        {
            var result = false;

            try
            {
                var client = await CreateInstanceAsyncForWrite();

                result = await client.KeyDeleteAsync(key);
            }
            catch (Exception ex)
            {
                Logger.Error(ex, ex.Message);
            }

            return result;
        }

        public async Task EndQueueAsync(string key, string item, long score)
        {
            var client = await CreateInstanceAsyncRead();

            if (score <= 0) score = Utils.DateTimeToUnixTime(DvgDateTime.Now);

            await client.SortedSetAddAsync(key, item, score);
        }

        public async Task EndQueueAsync(string key, string item)
        {
            var client = await CreateInstanceAsyncRead();

            await client.ListRightPushAsync(key, item);
        }

        public async Task<string> DeQueueAsync(string key)
        {
            var client = await CreateInstanceAsyncRead();

            return await client.ListLeftPopAsync(key);
        }

        public async Task EndQueueAsync<T>(string key, T item, long score)
        {
            try
            {
                if (score <= 0) score = Utils.DateTimeToUnixTime(DvgDateTime.Now);

                var value = NewtonJson.Serialize(item);

                var client = await CreateInstanceAsyncRead();

                await client.SortedSetAddAsync(key, value, score);
            }
            catch (Exception ex)
            {
                Logger.Error(ex, ex.Message);
            }
        }

        public async Task<T> DeQueueAsync<T>(string key)
        {
            try
            {
                var value = await DeQueueAsync(key);

                if (!string.IsNullOrEmpty(value)) return NewtonJson.Deserialize<T>(value);
            }
            catch (Exception ex)
            {
                Logger.Error(ex, ex.Message);
            }

            return default;
        }

        public bool CheckItemInList(string key)
        {
            try
            {
                var client = CreateInstanceRead();
                var list = client.ListRange(key, 0, 10);
                return list.Length > 0;
            }
            catch (Exception ex)
            {
                Logger.Error(ex, ex.Message);
            }

            return false;
        }

        public async Task<long> GetSortedSetCountAsync(string key)
        {
            var client = await CreateInstanceAsyncRead();

            return await client.SortedSetLengthAsync(key);
        }

        public async Task PushAsync(string key, string item)
        {
            var client = await CreateInstanceAsyncRead();

            await client.ListLeftPushAsync(key, item);
        }

        public async Task<string> PopAsync(string key)
        {
            var client = await CreateInstanceAsyncRead();

            return await client.ListLeftPopAsync(key);
        }

        public async Task SetEntryOrIncrementValueInHashAsync(string hashKey, string key)
        {
            var client = await CreateInstanceAsyncRead();

            await client.HashIncrementAsync(key, hashKey);
        }

        public async Task CloseAsync()
        {
            if (_connectionMultiplexer != null && _connectionMultiplexer.IsConnected)
                await _connectionMultiplexer.CloseAsync();
        }

        #endregion Async

        #region private methods

        private byte[] ZipToBytes<T>(T item, string key)
        {
            if (item == null || item.Equals(default(T)))
                return null;

            var bf = new BinaryFormatter();

            byte[] bytes;

            using (var ms = new MemoryStream())
            {
                bf.Serialize(ms, item);
                bytes = ms.ToArray();
            }

            //if (bytes.LongLength > _maxLengOfValueForMonitor)
            return bytes;
        }
        private T UnZipFromBytes<T>(byte[] bytes)
        {
            if (bytes == null || bytes.Length <= 0)
                return default;

            var bf = new BinaryFormatter();
            using (var ms = new MemoryStream(bytes))
            {
                var obj = bf.Deserialize(ms);
                return (T)obj;
            }
        }

        private void CopyTo(Stream src, Stream dest)
        {
            var bytes = new byte[8096];

            int cnt;

            while ((cnt = src.Read(bytes, 0, bytes.Length)) != 0) dest.Write(bytes, 0, cnt);
        }

        private byte[] Zip(string strInput, string key)
        {
            var bytes = Encoding.UTF8.GetBytes(strInput);

            using (var msi = new MemoryStream(bytes))
            using (var mso = new MemoryStream())
            {
                using (var gs = new GZipStream(mso, CompressionMode.Compress))
                {
                    //msi.CopyTo(gs);
                    CopyTo(msi, gs);
                }

                var newBytes = mso.ToArray();

                if (newBytes.LongLength > _maxLengOfValueForMonitor)
                    Logger.Info($"Leng of value <{key}> => {newBytes.LongLength}");

                return newBytes;
            }
        }

        private string Unzip(byte[] bytes)
        {
            using (var msi = new MemoryStream(bytes))
            using (var mso = new MemoryStream())
            {
                using (var gs = new GZipStream(msi, CompressionMode.Decompress))
                {
                    //gs.CopyTo(mso);
                    CopyTo(gs, mso);
                }

                return Encoding.UTF8.GetString(mso.ToArray());
            }
        }

        #endregion private methods
    }
}
