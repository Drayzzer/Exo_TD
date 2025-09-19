using UnityEngine;
using System.Collections.Generic;

namespace BouclesEtCollections
{
    public class Ex5 : MonoBehaviour
    {
        public List<GameObject> GameObjectList = new List<GameObject>();

        void Start()
        {
            foreach (GameObject obj in GameObjectList)
            {
                Destroy(obj);
            }
        }
    }
}