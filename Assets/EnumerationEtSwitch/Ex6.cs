using System.Collections.Generic;
using UnityEngine;

namespace EnumerationEtSwitch
{
    public class Ex6 : MonoBehaviour
    {
        public enum ColorChoice {Red, Green, Blue, Yellow}
        public List<GameObject> objectsToColor  = new List<GameObject>();
        public ColorChoice _selectedColor;
        void Update()
        {
            foreach (GameObject obj in objectsToColor)
            {
                switch (_selectedColor)
                {
                    case 0:
                        obj.GetComponent<Renderer>().material.color = Color.red;
                        break;
                    case (ColorChoice)1:
                        obj.GetComponent<Renderer>().material.color = Color.darkOliveGreen;
                        break;
                    case (ColorChoice)2:
                        obj.GetComponent<Renderer>().material.color = Color.darkBlue;
                        break;
                    case (ColorChoice)3:
                        obj.GetComponent<Renderer>().material.color = Color.yellowNice;
                        break;
                }
            }
        }
    }
}

