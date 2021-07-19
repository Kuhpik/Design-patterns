using System;

namespace Kuhpik.DesignPatterns.Structural.Adapter
{
    public static class UserEvents
    {
        public static Action<float> OnRest;
        public static Action<int> OnAttack;
    }
}
