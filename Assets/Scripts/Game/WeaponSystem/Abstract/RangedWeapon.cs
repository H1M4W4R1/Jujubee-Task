using Game.WeaponSystem.Data;
using Game.WeaponSystem.Data.Types;
using System;

namespace Game.WeaponSystem.Abstract
{
    public abstract class RangedWeapon : WeaponBase<RangedWeaponType>
    {
        /// <summary>
        /// Current bullets in magazine
        /// </summary>
        public int currentMagazine;

        /// <summary>
        /// Classified weapon data for this weapon
        /// </summary>
        public RangedWeaponData weaponData;

        public override RangedWeaponType GetSubtype() => weaponData.weaponType;

        public override bool IsSubtype(RangedWeaponType type)
        {
            return weaponData.weaponType == type;
        }

        /// <summary>
        /// On magazine reload (custom logic)
        /// </summary>
        public abstract void OnReload();
    }
}
