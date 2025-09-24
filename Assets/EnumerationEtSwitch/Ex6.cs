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
                    case ColorChoice.Red:
                        obj.GetComponent<Renderer>().material.color = Color.red;
                        break;
                    case ColorChoice.Green:
                        obj.GetComponent<Renderer>().material.color = Color.darkOliveGreen;
                        break;
                    case ColorChoice.Blue:
                        obj.GetComponent<Renderer>().material.color = Color.darkBlue;
                        break;
                    case ColorChoice.Yellow:
                        obj.GetComponent<Renderer>().material.color = Color.yellowNice;
                        break;
                }
            }
        }
    }
}

