using Game.WeaponSystem.Data;
using System;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace Game.WeaponSystem.Abstract
{
    /// <summary>
    /// Represents base weapon structure and methods shared by all weapon types
    /// </summary>
    public abstract class WeaponBase<TWeaponSubtypeEnum> : MonoBehaviour, IWeapon
    {
        /// <summary>
        /// Weapon icon
        /// </summary>
        [SerializeField] private AssetReferenceSprite weaponIcon;

        /// <summary>
        /// Basic data for this weapon
        /// </summary>
        public WeaponData commonWeaponData;

        /// <summary>
        /// Base weapon damage for this weapon
        /// </summary>
        public UInt32 GetBaseDamage() => commonWeaponData.baseDamage;

        /// <summary>
        /// Weapon name, shall be used only within UI
        /// </summary>
        public string GetName() => commonWeaponData.name;

        /// <summary>
        /// Check if weapon is of specified subtype, implement using custom weapon data properties
        /// If subtypes are not implemented for that weapon then should return true
        /// </summary>
        public abstract bool IsSubtype(TWeaponSubtypeEnum type);

        /// <summary>
        /// Get weapon subtype for this weapon
        /// </summary>
        public abstract TWeaponSubtypeEnum GetSubtype();

        /// <summary>
        /// Loads icon using addressables and uses it in specific action
        /// If icon is already loaded then grabs it from cache.
        /// </summary>        
        public void UseWeaponIcon(Action<Sprite> onIconFound)
        {
            // Do not use == null comparison, it's inefficient
            if (weaponIcon.IsValid()) onIconFound.Invoke((Sprite)weaponIcon.Asset);
            else
            {
                // Request sprite load and use loaded icon in world, hope unity does it on main thread
                var loadRequest = weaponIcon.LoadAssetAsync<Sprite>();
                loadRequest.Completed += lHandle => onIconFound.Invoke(loadRequest.Result);
            }
        }

        /// <summary>
        /// Executed on attack using this weapon
        /// </summary>
        public abstract void OnAttack();
    }

}
