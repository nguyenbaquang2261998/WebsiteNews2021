using System.Collections.Generic;
using System.Threading.Tasks;

namespace DOLPHIN.Caching.Interfaces
{
    public interface IQueueAndListCached
    {
        void EndQueue(string key, string item, long score);

        string DeQueue(string key);

        void EndQueue<T>(string key, T item, long score);

        T DeQueue<T>(string key);

        List<T> DeQueueList<T>(string key);

        Task EndQueueAsync(string key, string item);
        Task<string> DeQueueAsync(string key);

        long GetSortedSetCount(string key);

        void Push(string key, string item);

        string Pop(string key);

        long SetEntryOrIncrementValueInHash(string hashKey, string key);

        List<string> GetAllEntriesAndRemoveFromHash(string hashkey);

        List<T> GetAllItemsFromQueue<T>(string key);

        bool CheckItemInList(string key);
        bool Remove(string key);
    }
}