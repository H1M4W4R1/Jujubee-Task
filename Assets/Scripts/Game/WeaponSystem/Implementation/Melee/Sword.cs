using Game.WeaponSystem.Abstract;
using UnityEngine;

namespace Game.WeaponSystem.Implementation.Melee
{
    public class Sword : MeleeWeapon
    {
        [ContextMenu("Weapons/Test Attack")]
        public override void OnAttack()
        {
            Debug.Log($"Sword is slashing through the air dealing {GetBaseDamage()} damage to enemies.");
        }
    }
}
