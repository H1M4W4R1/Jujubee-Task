using Game.WeaponSystem.Data.Types;
using System;

namespace Game.WeaponSystem.Data
{
    /// <summary>
    /// Represents ranged weapon (bow, gun or even a wand)
    /// </summary>
    [Serializable]
    public struct RangedWeaponData
    {
        /// <summary>
        /// Amount of projectiles in magazine. 0 or lower means that weapon has unlimited magazine capacity.
        /// </summary>
        public int magazineProjectileCount;

        /// <summary>
        /// Type of this weapon
        /// </summary>
        public RangedWeaponType weaponType;

    }
}
