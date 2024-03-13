using Game.WeaponSystem.Abstract;
using UnityEngine;

namespace Game.WeaponSystem.Implementation.Melee
{
    public class Dagger : MeleeWeapon
    {
        [ContextMenu("Weapons/Test Attack")]
        public override void OnAttack()
        {
            Debug.Log($"Sneaky dagger backstabs opponent dealing {GetBaseDamage()} damage.");
        }
    }
}