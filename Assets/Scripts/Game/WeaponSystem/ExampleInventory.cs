using Game.WeaponSystem.Abstract;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Game.WeaponSystem
{
    public class ExampleInventory : MonoBehaviour
    {
        // TODO: move this to more reasonable place (like own UI script?)
        public TextMeshProUGUI weaponNameText;

        // TODO: move this to more reasonable place (like own UI script?)
        public Image weaponSpriteDisplay;

        private int _currentWeapon = 0;
        private List<IWeapon> _weapons = new List<IWeapon>();

        private IWeapon CurrentWeapon => _weapons[_currentWeapon];

        private void Awake()
        {
            // Load all weapons
            _weapons.AddRange(GetComponentsInChildren<IWeapon>());

            if (_weapons.Count < 1)
                Debug.LogError("Please give me some weapons", this);

            ProcessWeaponSwap();
        }

        public void SelectWeapon(int n)
        {
            if(n >= 0 && n < _weapons.Count)            
                _currentWeapon = n;

            ProcessWeaponSwap();
        }

        public void NextWeapon()
        {
            if (_currentWeapon + 1 < _weapons.Count)
                _currentWeapon++;
            else
                _currentWeapon = 0;

            ProcessWeaponSwap();
        }

        public void ProcessWeaponSwap()
        {
            // Update UI, because why not -,-
            weaponNameText.text = CurrentWeapon.GetName();
            CurrentWeapon.UseWeaponIcon(sprite => weaponSpriteDisplay.sprite = sprite);
        }

        public void Attack() =>        
            CurrentWeapon.OnAttack();

        public void Reload()
        {
            if (CurrentWeapon is RangedWeapon rWeapon)
                rWeapon.OnReload();
        }
        
    }
}
