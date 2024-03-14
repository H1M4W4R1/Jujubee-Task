# Task
Within Unity 2021.3.11 create a weapon system (melee and ranged) with possibility to add other weapon types.

## Logic:
- All weapons have common attributes
  - Damage
  - Weapon Name
- Weapon type can have unique attributes
  - Ranged weapon can have projectile limit
- All weapons have custom gameplay logic (implemented using example log messages)
- Each weapon type can have subtypes: eg. melee weapon can be both dagger and sword

## UI:
After scene is loaded:
- Player can see weapon name on screen
- Player can see weapon icon on screen
  - Use Addressables for weapon icon implementation

## Input:
- LMB attacks using weapon (Debug.Log)
- RMB changes weapon to next one
- (optional) numeric keys change weapon to specific slot

# Assumptions and decisions made during task
- Tech stack is unknown (probably Burst), so weapon data should be implemented as unmanaged structs
  - Alternatively it could be implemented directly within Weapon classes (WeaponBase, RangedWeapon, MeleeWeapon).
- For showcase purposes use of external packages shall be limited (including OdinInspector thus custom editors were not implemented)
  - Theoretically it could be implemented using UI Toolkit, but I prefer Odin for simplicity, coding efficiency and less mess
- This is a simple showcase, so creating custom UI scripts that get data from weapon inventory and display it would be overkill
  - This can be fixed by creation of custom UI Scripts like "DisplayWeaponName.cs" which would access weapon inventory through reference and grab currently equipped weapon name.
 
# Time it took to execute task
- Start: 12:15
- End of coding: 12:45
- End of basic code review: 13:45
- Pauses: 15 minute break to eat dinner
- Total: 1h 15min (probably shorter)
