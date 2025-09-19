using UnityEngine;

namespace GameloopEtHierarchie
{
    public class ColoredCollisionComponent : MonoBehaviour
    {
        public Color _CollisionColor; // ceci est un champs 
        private Color _BaseColor;

        void Awake()
        {
            _BaseColor = GetComponent<MeshRenderer>().material.color;
            // _BaseColor est une variable
            // = est un operateur d'assignation qui assigne le composant de droite a celui de gauche  
            // GetComponent permet de récuperer un composant dans la variable a gauche 
            // MeshRenderer est un composant 
            // material est une valeur d'un composant 
            // color aussi valeur d'un composant
            // tout ce qui est apres le point est une valeur 
        }


        void OnTriggerEnter()
        {
            _CollisionColor = GetComponent<MeshRenderer>().material.color = Color.purple;
        }

        void OnTriggerExit()
        {
            _BaseColor = GetComponent<MeshRenderer>().material.color = Color.black;
        }
    }
}    

