using System;

namespace Game.WeaponSystem.Data
{
    /// <summary>
    /// Burst-compatible weapon information structure
    /// Could've used polymorphism or scriptable object, but this can significantly improve efficiency in calculations
    /// </summary>
    [Serializable]
    public struct WeaponData
    {
        /// <summary>
        /// Weapon name
        /// </summary>
        public string name;

        /// <summary>
        /// Base damage this weapon deals to enemies
        /// </summary>
        public UInt32 baseDamage;

    }
}
