using UnityEngine;

namespace Kuhpik.DesignPatterns.Structural.Flyweight
{
    public class FlyweightData
    {
        readonly public Sprite Sprite;
        readonly public string ModelName;
        readonly public Color Color;
        readonly public Color WheelColor;

        public FlyweightData(Sprite sprite, string modelName, Color color, Color wheelColor)
        {
            Sprite = sprite;
            ModelName = modelName;
            Color = color;
            WheelColor = wheelColor;
        }
    }
}
