using NaughtyAttributes;
using UnityEngine;

namespace Kuhpik.DesignPatterns.Behavioral.Mediator
{
    public class TestScript : MonoBehaviour
    {
        [Button]
        void Test()
        {
            var mediator = new UIMediator();
            var tapToStartBtn = new TapToStartButton(mediator);
            var restartBtn = new RestartButton(mediator);

            mediator.RestartButton = restartBtn;
            mediator.TapToStartButton = tapToStartBtn;

            tapToStartBtn.Click();
            restartBtn.Click();
        }
    }
}
