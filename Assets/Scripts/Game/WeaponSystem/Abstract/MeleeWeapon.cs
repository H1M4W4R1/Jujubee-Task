using Game.WeaponSystem.Data;
using Game.WeaponSystem.Data.Types;
using System;

namespace Game.WeaponSystem.Abstract
{
    public abstract class MeleeWeapon : WeaponBase<MeleeWeaponType>
    {
        /// <summary>
        /// Classified weapon data for this weapon
        /// </summary>
        public MeleeWeaponData weaponData;

        public override MeleeWeaponType GetSubtype() => weaponData.weaponType;

        public override bool IsSubtype(MeleeWeaponType type)
        {
            return weaponData.weaponType == type;
        }
    }
}
