using NaughtyAttributes;
using UnityEngine;

namespace Kuhpik.DesignPatterns.Builder
{
    public class TestScript : MonoBehaviour
    {
        [Button("Weapon")]
        void SimpleCharacter()
        {
            var character = new CharacterBuilder().EquipWeapon("Spear").Get();
        }

        [Button("WithGoodEquipment")]
        void NiceCharacter()
        {
            var character = new CharacterBuilder().EquipWeapon("Excalibur").EquipPet("Octocat")
                .EquipBlessing("Overspeed").EquipArmor("Undying Set")
                .Get();
        }
    }
}
