using Game.WeaponSystem.Data.Types;
using System;

namespace Game.WeaponSystem.Data
{
    /// <summary>
    /// Represents melee weapon information
    /// </summary>
    [Serializable]
    public struct MeleeWeaponData
    {
        /// <summary>
        /// Type of this weapon
        /// </summary>
        public MeleeWeaponType weaponType;
    }
}
