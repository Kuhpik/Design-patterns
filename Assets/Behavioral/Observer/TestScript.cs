using NaughtyAttributes;
using UnityEngine;

namespace Kuhpik.DesignPatterns.Behavioral.Observer
{
    public class TestScript : MonoBehaviour
    {
        [Button]
        void Test()
        {
            var tracker = new PlayerStatsTracker();
            var achievementSystem = new AchievementSystem();
            var serverAchievementSystem = new ServerAchievementSystem();

            tracker.Subscribe(achievementSystem);
            tracker.Subscribe(serverAchievementSystem);

            tracker.OnKill(10);
            tracker.OnLevelup(1);
            tracker.OnKill(25);
            tracker.OnLevelup(2);
            tracker.OnFacebookConnected();
            tracker.Forget(serverAchievementSystem);
            tracker.OnFacebookConnected();
        }
    }
}
