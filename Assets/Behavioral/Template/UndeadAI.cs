using UnityEngine;

namespace Kuhpik.DesignPatterns.Behavioral.TemplateMethod
{
    public class UndeadAI : EnemyAI
    {
        protected override void GatherResources()
        {
            Debug.Log("Gathering dead bodies at first");
        }

        protected override void AttackVilage()
        {
            Debug.Log("Very agressive attack");
        }

        protected override void RecruitSoldiers()
        {
            Debug.Log("Only hire Necromants and making zombies");
        }
    }
}