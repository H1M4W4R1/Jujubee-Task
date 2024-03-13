using UnityEngine;

namespace Game.WeaponSystem
{
    /// <summary>
    /// Must be placed on object with ExampleInventory script
    /// Represents input system (aka. keyboard and mouse processing)
    /// </summary>
    public class ExampleInputSystem : MonoBehaviour
    {
        private ExampleInventory _inventory;

        private void Awake()
        {
            _inventory = GetComponent<ExampleInventory>();
        }

        public void Update()
        {
            // Select weapon (1-9)
            for (var keyCode = KeyCode.Alpha1; keyCode < KeyCode.Alpha9; keyCode++)
                if (Input.GetKeyDown(keyCode))
                    _inventory.SelectWeapon(keyCode - KeyCode.Alpha1);
            if (Input.GetKeyDown(KeyCode.Alpha0)) _inventory.SelectWeapon(9);

            // Rise Atlantis, RISE!
            if (Input.GetMouseButtonDown(0))
                _inventory.Attack();

            // Just for test coverage
            if (Input.GetMouseButtonDown(1))
                _inventory.NextWeapon();

            // Reload
            if (Input.GetKeyDown(KeyCode.R))
                _inventory.Reload();
        }

    }
}
