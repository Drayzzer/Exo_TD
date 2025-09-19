using UnityEngine;
using System.Collections.Generic;

namespace BouclesEtCollections
{
    public class eX4 : MonoBehaviour
    {
        void Start()
        {
            List<string> NameList = new List<string>();
            NameList.Add("Jordan");
            NameList.Add("tom");
            NameList.Add("alexis");
            foreach (string Names in NameList)
            {
                print(Names);
            }
        }
    }
}