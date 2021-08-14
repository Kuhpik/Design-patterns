using System.Collections.Generic;
using UnityEngine;

namespace Kuhpik.DesignPatterns.Structural.Flyweight
{
    public class FlyweightRefFactory
    {
        readonly Dictionary<FlyweightCarTuple, FlyweightData> _flyweights;

        public FlyweightRefFactory()
        {
            _flyweights = new Dictionary<FlyweightCarTuple, FlyweightData>();
        }

        public FlyweightData GetFlyweightData(string name, Sprite sprite, ref Color color, ref Color wheelColor)
        {
            var tuple = new FlyweightCarTuple(name, sprite, color, wheelColor);

            if (_flyweights.ContainsKey(tuple))
            {
                return _flyweights[tuple];
            }

            else
            {
                var data = new FlyweightData(sprite, name, ref color, ref wheelColor);
                _flyweights.Add(tuple, data);
                return data;
            }
        }
    }
}
