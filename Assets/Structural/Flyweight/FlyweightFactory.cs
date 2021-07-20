﻿using System.Collections.Generic;
using UnityEngine;

namespace Kuhpik.DesignPatterns.Structural.Flyweight
{
    public class FlyweightFactory
    {
        readonly Dictionary<string, FlyweightData> _flyweights;

        public FlyweightFactory()
        {
            _flyweights = new Dictionary<string, FlyweightData>();
        }

        public FlyweightData GetFlyweightData(string name, Sprite sprite, Color color, Color wheelColor)
        {
            var hash = string.Format("{0}_{1}_{2}_{3}", name, sprite.name, color, wheelColor);

            if (_flyweights.ContainsKey(hash))
            {
                return _flyweights[hash];
            }

            else
            {
                var data = new FlyweightData()
                {
                    ModelName = name,
                    Sprite = sprite,
                    Color = color,
                    WheelColor = wheelColor
                };

                _flyweights.Add(hash, data);

                return data;
            }
        }
    }
}
