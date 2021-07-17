namespace Kuhpik.DesignPatterns.Creational.Prototype
{
    public sealed class Effect : IPrototypable<Effect>
    {
        public string Name { get; private set; }
        public float Value { get; private set; }
        public float Time { get; private set; }
        public float TimeLeft { get; private set; }

        public Effect(string name, float value, float time, float timeleft = 0)
        {
            Name = name;
            Value = value;
            Time = time;
            TimeLeft = timeleft == 0 ? time : timeleft;
        }

        public Effect DeepCopy()
        {
            return new Effect(Name, Value, Time, TimeLeft);
        }
    }
}
