using System;
using System.Collections.Generic;
using System.Linq;

namespace LPS_Test_Soal_1_7
{
    public class Cache
    {
        private static Dictionary<int, object> _cache = new Dictionary<int, object>();
        private const int MaxCacheSize = 1000; // Set a maximum cache size

        public static void Add(int key, object value)
        {
            if (_cache.Count >= MaxCacheSize)
            {
                // Remove the oldest item when the cache size exceeds the limit
                int oldestKey = _cache.Keys.Min();
                _cache.Remove(oldestKey);
            }

            _cache.Add(key, value);
        }

        public static object Get(int key)
        {
            return _cache[key];
        }
    }

    public class Soal7Class
    {
        public void RunCacheExample()
        {
            for (int i = 0; i < 1000000; i++)
            {
                Cache.Add(i, new object());
            }

            Console.WriteLine("Cache populated");
            Console.ReadLine();
        }
    }
}
