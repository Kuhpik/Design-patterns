using Kuhpik.DesignPatterns.Others.Memoizer;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Kuhpik.DesignPatterns.Structural.Flyweight
{
    public class FlyweightMemoizerFactory
    {
        readonly Dictionary<string, FlyweightData> _flyweights;
        readonly Memoizer<FlyweightCarTuple, string> _memoizer;

        public FlyweightMemoizerFactory()
        {
            _flyweights = new Dictionary<string, FlyweightData>();
            _memoizer = new Memoizer<FlyweightCarTuple, string>();
        }

        public FlyweightData GetFlyweightData(string name, Sprite sprite, Color color, Color wheelColor)
        {
            var tuple = new FlyweightCarTuple(name, sprite, color, wheelColor);
            var hash = _memoizer.Memoize(tuple, (x) =>
            {
                return string.Format("{0}_{1}_{2}_{3}", x.Item1, x.Item2, x.Item3, x.Item4);
            });

            if (_flyweights.ContainsKey(hash))
            {
                return _flyweights[hash];
            }

            else
            {
                var data = new FlyweightData(sprite, name, color, wheelColor);
                _flyweights.Add(hash, data);
                return data;
            }
        }
    }

    public class FlyweightCarTuple : Tuple<string, Sprite, Color, Color>
    {
        public FlyweightCarTuple(string name, Sprite sprite, Color carColor, Color wheelColor)
            : base(name, sprite, carColor, wheelColor) { }
    }
}
