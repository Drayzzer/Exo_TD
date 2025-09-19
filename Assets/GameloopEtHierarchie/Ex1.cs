using UnityEngine;

namespace GameloopEtHierarchie
{
    public class Ex1 : MonoBehaviour
    {
        void Update() // ceci est une méthode,
                      // void est une type ou retour et
                      // Update est le nom de la méthode (et fait partie du gameloop )
                      // les () sont des paramètres vides
        {
            Debug.Log("UpdateTime"+Time.deltaTime);  
            //Debug.Log permet d'afficher sur la console unity
            //"" sert de chaine de caractère
            //le + est un operateur qui comme en math sert d'addition
            //Time est un composant et deltaTime est un valeur du composant 
            //le . est un opérateur d'accessibilité qui permet de sortir un élément de l'opérande de gauche.
            //donc dans le cas de Time.deltaTime il se passe que le . permet d'acceder a deltaTime dans Time
        } 
        void FixedUpdate()
        {
            Debug.Log("FixedUpdateTime"+Time.deltaTime);
        }
    }
}
