using System;
using System.Collections.Generic;

namespace Kuhpik.DesignPatterns.Others.Memoizer
{
    public class Memoizer<I, O>
    {
        readonly Dictionary<I, O> _cache;

        public Memoizer()
        {
            _cache = new Dictionary<I, O>();
        }

        public O Memoize(I input, Func<I,O> func)
        {
            if (_cache.ContainsKey(input)) //This case will much more often
            {
                return _cache[input];
            }

            else
            {
                var value = func(input);
                _cache.Add(input, value);
                return value;
            }
        }
    }
}
