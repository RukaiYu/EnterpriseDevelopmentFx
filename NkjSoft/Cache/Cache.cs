
using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Web;
using NkjSoft.Cache.Interfaces;


namespace NkjSoft.Cache
{
    /// <summary>
    /// Cache manager using AspNet which groups all the keys with a prefix.
    /// </summary>
    public class Cacher
    {
        private static ICache _provider;

        /// <summary>
        /// Initialize with spring cache.
        /// </summary>
        /// <param name="springCache"></param>
        static Cacher()
        {

        }


        /// <summary>
        /// Get the current cache provider being used.
        /// </summary>
        public static ICache Provider
        {
            get { return _provider; }
        }


        /// <summary>
        /// Initialize the cache provider.
        /// </summary>
        /// <param name="cacheProvider"></param>
        public static void Init(ICache cacheProvider)
        {
            _provider = cacheProvider;
        }


        #region ICache Members

        /// <summary>
        /// Get the number of items in the cache that are 
        /// associated with this instance.
        /// </summary>
        public static int Count
        {
            get
            {
                return _provider.Count;
            }
        }


        /// <summary>
        /// Get the collection of cache keys associated with this instance of
        /// cache ( using the cachePrefix ).
        /// </summary>
        public static ICollection Keys
        {
            get
            {
                return _provider.Keys;
            }
        }


        /// <summary>
        /// Whether or not there is a cache entry for the specified key.
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static bool Contains(string key)
        {
            return _provider.Contains(key);
        }


        /// <summary>
        /// Retrieves an item from the cache.
        /// </summary>
        public static object Get(object key)
        {
            return _provider.Get(key);
        }


        /// <summary>
        /// Get the object associated with the key
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static T Get<T>(object key)
        {
            return _provider.Get<T>(key);
        }


        /// <summary>
        /// Remove from cache.
        /// </summary>
        /// <param name="key"></param>
        public static void Remove(object key)
        {
            _provider.Remove(key);
        }


        /// <summary>
        /// Remove all the items associated with the keys specified.
        /// </summary>
        /// <param name="keys"></param>
        public static void RemoveAll(ICollection keys)
        {
            _provider.RemoveAll(keys);
        }


        /// <summary>
        /// Clear all the items in the cache.
        /// </summary>
        public static void Clear()
        {
            _provider.Clear();
        }


        /// <summary>
        /// Insert an item into the cache.
        /// </summary>
        /// <param name="key">The cache key</param>
        /// <param name="value">The cache value</param>
        public static void Insert(object key, object value)
        {
            _provider.Insert(key, value);
        }


        /// <summary>
        /// Insert an item into the cache with the specified sliding expiration.
        /// </summary>
        /// <param name="key">The cache key</param>
        /// <param name="value">The cache value</param>
        /// <param name="timeToLive">How long in seconds the object should be cached.</param>
        /// <param name="slidingExpiration">Whether or not to reset the time to live if the object is touched.</param>
        public static void Insert(object key, object value, int timeToLive, bool slidingExpiration)
        {
            _provider.Insert(key, value, timeToLive, slidingExpiration);
        }


        /// <summary>
        /// Insert an item into the cache with the specified time to live, 
        /// sliding expiration and priority.
        /// </summary>
        /// <param name="key">The cache key</param>
        /// <param name="value">The cache value</param>
        /// <param name="timeToLive">How long in seconds the object should be cached.</param>
        /// <param name="slidingExpiration">Whether or not to reset the time to live if the object is touched.</param>
        /// <param name="priority">Priority of the cache entry.</param>
        public static void Insert(object key, object value, int timeToLive, bool slidingExpiration, CacheItemPriority priority)
        {
            _provider.Insert(key, value, timeToLive, slidingExpiration, priority);
        }
        #endregion
    }
}
