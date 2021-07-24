using NaughtyAttributes;
using UnityEngine;

namespace Kuhpik.DesignPatterns.Behavioral.TemplateMethod
{
    public class TestScript : MonoBehaviour
    {
        [Button]
        void Test()
        {
            var uneadead = new UndeadAI();
            var neutral = new NeutralsAI();
            var humans = new HumansAI();

            Debug.Log("<color=green>Undead's Turn</color>");
            uneadead.PerformAction();

            Debug.Log("<color=maroon>Neutrals's Turn</color>");
            neutral.PerformAction();

            Debug.Log("<color=yellow>Himan's Turn</color>");
            humans.PerformAction();
        }
    }
}
