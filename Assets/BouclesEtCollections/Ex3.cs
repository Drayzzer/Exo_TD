using UnityEngine;
using System.Collections.Generic;
namespace BouclesEtCollections
{
    public class Ex3 : MonoBehaviour
    {
        public List<string> Names = new List<string> ();
   
        void Start()
        {
            for (int i = 0; i < Names.Count; i++)
            {
                print (Names[i]);
            }
        }
    }
}