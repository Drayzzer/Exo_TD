using UnityEngine;
using UnityEngine.UIElements;

namespace InteractionEtManipulation
{
    public class Ex3 : MonoBehaviour
    {
        public int speed = 2;
        //ceci est un champ
        //int est un type entier
        //speed est une variable à laquelle j'ai assigné la valeur 2 grace a l'operateur =
        void FixedUpdate()
        // ceci est une méthode
        //FixedUpdate fait parti du GameLoop et sert à faire des updates a des frames égales
        {
            float horizontalValue = Input.GetAxis("Horizontal") * speed;
            //float est un type décimal
            //Input me permet davoir accès au controle 
            //Getaxis me permet de gérer une rotation d'un axe
            //speed est la variable que j'ai créé
            // cette méthode me permet de pouvoir bouger mon personnage sur l'axe x
            float verticalValue = Input.GetAxis("Vertical")  * speed;
            // cette méthode me permet de bouger mon personnage sur l'axe y
            
            transform.Translate(horizontalValue * Time.deltaTime, 0, verticalValue * Time.deltaTime);
            //transform est un composant qui gère les positions, rotations et scale de mon perso
            //Translate me permet de modifier cela 
            //horizontalValue * Time.deltatime me permet de multiplier la valeur que j'ai assigné a ma variable a ma variable speed
            // ce script me permet de faire bouger mon perso sur l'axe x et y
        }
    }
}

