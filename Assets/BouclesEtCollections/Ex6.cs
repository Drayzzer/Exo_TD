using UnityEngine;
using System.Collections.Generic;

namespace BouclesEtCollections
{
    public class Ex6 : MonoBehaviour
    {
        public List<GameObject> GameObjectToColorList  = new List<GameObject>();
        public GameObject GameObjectToRemove;
        void Start()
        {
            GameObjectToColorList.Remove(GameObjectToRemove);
            foreach (GameObject obj in GameObjectToColorList)
            {
                obj.GetComponent<Renderer>().material.color = Color.red;
            }
        }
    }
}