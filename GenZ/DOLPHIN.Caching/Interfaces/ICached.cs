using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace DOLPHIN.Caching.Interfaces
{
    public interface ICached
    {
        bool Set<T>(string key, T item, int expireInMinute = 0);

        bool Remove(string key);

        T Get<T>(string key, HttpContext context = null);

        Task<T> GetAsync<T>(string key, HttpContext context = null);

        Task<string> GetAsync(string key, HttpContext context = null);

        Task<bool> SetAsync<T>(string key, T item, int expireInMinute = 0);

        Task<bool> SetAsync(string key, string item, int expireInMinute = 0);

        Task<bool> RemoveAsync(string key);

        Task CloseAsync();
    }
}