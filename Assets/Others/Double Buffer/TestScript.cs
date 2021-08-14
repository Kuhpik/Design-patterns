using NaughtyAttributes;
using UnityEngine;

namespace Kuhpik.DesignPatterns.Others.DoubleBuffer
{
    public class TestScript : MonoBehaviour
    {
        [Button]
        void Test()
        {
            var leaderboard = new Leaderboard();

            leaderboard.SaveProgress(new LeaderboardRecord("Rick", 200));
            leaderboard.SaveProgress(new LeaderboardRecord("Morty", 80));

            leaderboard.Refresh();
            leaderboard.ShowHighest();

            leaderboard.SaveProgress(new LeaderboardRecord("Summer", 120));
            leaderboard.SaveProgress(new LeaderboardRecord("Doggo", 8000));

            leaderboard.ShowHighest();
            leaderboard.Refresh();
            leaderboard.ShowHighest();
        }
    }
}
