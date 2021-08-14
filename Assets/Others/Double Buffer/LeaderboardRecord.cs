namespace Kuhpik.DesignPatterns.Others.DoubleBuffer
{
    public class LeaderboardRecord
    {
        public readonly string Name;
        public readonly int Score;

        public LeaderboardRecord(string name, int score)
        {
            Name = name;
            Score = score;
        }
    }
}