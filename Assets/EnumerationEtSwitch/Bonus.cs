using UnityEngine;

namespace EnumerationEtSwitch
{
    [System.Flags] enum WeaponType {Sword, Bow, Axe, Staff}
    public class Bonus : MonoBehaviour
    {
        void Start()
        {
            WeaponType myWeapons = WeaponType.Sword | WeaponType.Bow | WeaponType.Axe | WeaponType.Staff;

            if (myWeapons == WeaponType.Sword)
            {
                Debug.Log("i have a sword");
            }

            if (myWeapons == WeaponType.Bow)
            {
                Debug.Log("i have a bow");
            }

            if (myWeapons == WeaponType.Axe)
            {
                Debug.Log("i have a axe");
            }

            if (myWeapons == WeaponType.Staff)
            {
                Debug.Log("i have a staff");
            }
        }
    }
}
