using System;
using UnityEngine;

namespace Game.WeaponSystem.Abstract
{
    /// <summary>
    /// Weapon interface pseudo-proxy
    /// </summary>
    public interface IWeapon
    {
        UInt32 GetBaseDamage();
        string GetName();
        void OnAttack();
        void UseWeaponIcon(Action<Sprite> onIconFound);
    }
}
