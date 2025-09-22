using UnityEngine;
using System.Collections.Generic;

namespace BouclesEtCollections
{
    public class Ex6 : MonoBehaviour
    {
        public List<GameObject> GameObjectToColorList  = new List<GameObject>();
        //List<GameObject> est une collection de type Liste qui contient plusieurs GameObjects qui est vide
        //GameObjectToColorList est une variable 
        //
        public GameObject GameObjectToRemove;
        void Start()
        {
            GameObjectToColorList.Remove(GameObjectToRemove);
            //remove me permet de supprimer des GameObjectToRemove dans GameObjectToColorList
            
            foreach (GameObject obj in GameObjectToColorList) 
                //foreach est une boucle qui parcour tout les éléments dans une liste
            // obj est une variable qui a était creer de type GameObject
            //GameObject est le type de la liste
            {
                obj.GetComponent<Renderer>().material.color = Color.red;
                //GetComponent permet de récuperer un composant
                //Renderer est le composant en question 
                //material est un composant du renderer 
                //color est un composant du material
                //Color c'est une fonction qui définis la couleur du gameobject
            }
        }
    }
}