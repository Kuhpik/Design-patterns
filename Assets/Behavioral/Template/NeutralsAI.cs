using UnityEngine;

namespace Kuhpik.DesignPatterns.Behavioral.TemplateMethod
{
    public class NeutralsAI : EnemyAI
    {
        protected override void GatherResources()
        {
            Debug.Log("Do some hunt");
        }

        protected override void BuildTown()
        {
            Debug.Log("Nothing to build. Camp is our only home");
        }
    }
}