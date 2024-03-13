using Game.WeaponSystem.Abstract;
using UnityEngine;

namespace Game.WeaponSystem.Implementation.Melee
{
    /// <summary>
    /// Represents base structure for a gun, can be abstracted even further for SMG, Snipers etc.
    /// </summary>
    public class Gun : RangedWeapon
    {
        [ContextMenu("Weapons/Test Attack")]
        public override void OnAttack()
        {
            if (currentMagazine > 0) {
                Debug.Log($"You hear loud noise and see swiss-cheesed enemies who got {GetBaseDamage()} damage.");
                currentMagazine--;
            }
            else
            {
                Debug.Log("An deafed click can be heard from your weapon. I think it might be quite empty.");
            }
        }

        public override void OnReload()
        {
            // Reload magazine
            currentMagazine = weaponData.magazineProjectileCount;

            Debug.Log("Your slick hand push new bullets into magazine. You're ready to shoot again!");
        }

        private void Awake()
        {
            // Load weapon on start of the game
            currentMagazine = weaponData.magazineProjectileCount;
        }
    }
}
