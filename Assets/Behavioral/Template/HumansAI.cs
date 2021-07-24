using UnityEngine;

namespace Kuhpik.DesignPatterns.Behavioral.TemplateMethod
{
    public class HumansAI : EnemyAI
    {
        protected override void AttackVilage()
        {
            Debug.Log("Don't wanna lose ally's. Playing defensively");
        }
    }
}