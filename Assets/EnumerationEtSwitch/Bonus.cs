using UnityEngine;

namespace EnumerationEtSwitch
{
    [System.Flags]
    public enum WeaponType
    {
        Sword = 1, 
        Bow = 2, 
        Axe = 4,
        Staff = 8
    }
    
    public class Bonus : MonoBehaviour
    {
        
        public WeaponType myWeapons;
        
        void Start()
        {

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
