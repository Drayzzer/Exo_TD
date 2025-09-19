using UnityEngine;

namespace BouclesEtCollections
{
    public class Ex2 : MonoBehaviour
    {
        void Start()
        {
            int a = 7;
            int b = 5;
            int result = 0;
            for (int i = 0; i <= a; i++)
            {
                result += b;
                Debug.Log("itération " + i + result);
            }
            print("result " + result);
        }
    }
}