using UnityEngine;

namespace BouclesEtCollections
{
    public class Ex1 : MonoBehaviour
    {
        void Start()
        {
            int repeatNumber = 7;
            string message = "grisouille";
            while (repeatNumber > 0) {
                Debug.Log("non");
                repeatNumber--;
            }
            print (message + repeatNumber);
        }
    }
}