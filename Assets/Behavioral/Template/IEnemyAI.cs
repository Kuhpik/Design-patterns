using UnityEngine;

namespace Kuhpik.DesignPatterns.Behavioral.TemplateMethod
{
    public abstract class EnemyAI
    {
        //Algorithm will not change
        public void PerformAction()
        {
            GatherResources();
            BuildTown();
            RecruitSoldiers();
            AttackVilage();
        }

        protected virtual void BuildTown()
        {
            Debug.Log("Building offence structures at first");
        }

        protected virtual void AttackVilage()
        {
            Debug.Log("Attack closes village if possible");
        }

        protected virtual void GatherResources()
        {
            Debug.Log("Gather a piece of everything");
        }

        protected virtual void RecruitSoldiers()
        {
            Debug.Log("Recruit strongest ones");
        }
    }
}
