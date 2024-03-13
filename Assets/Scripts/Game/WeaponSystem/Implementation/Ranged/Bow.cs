using Game.WeaponSystem.Abstract;
using UnityEngine;

namespace Game.WeaponSystem.Implementation.Melee
{
    public class Bow : RangedWeapon
    {
        [ContextMenu("Weapons/Test Attack")]
        public override void OnAttack()
        {
            Debug.Log($"Ancient wild spirits guide your arrows dealing {GetBaseDamage()} damage.");
        }

        public override void OnReload()
        {
            Debug.Log("Bow cannot be reloaded!");
        }
    }
}
