using UnityEngine;
using UnityEngine.Windows.WebCam;

namespace EnumerationEtSwitch
{
    public class Ex2 : MonoBehaviour
    {
        enum DaysOfWeek { Lundi, Mardi, Mercredi, Jeudi, Vendredi, Samedi, Dimanche };
        //enum est le mot clé pour déclarer une énumeration
        void Start()
        { 
            int today = 4;
            // est une instruction
            // int est un type entier
            // today est le nom de la variable
            // = est un operateur d'assignation qui assigne l'operande de droite a celui de gauche 
            switch (today)
            //un switch a la meme utilité qu'un if mais en plus simplifier pour eviter plusieurs if
            // c'est comme une version amélioré 
            //today est la variable qu'on vérifie dans le switch
            {
                case 0 :
                    //case est comme un if exemple si la variable = 0 alors afficher 
                    //0 est la valeur qu'on met dans le cas ou today = 0
                    Debug.Log("Début de semaine !");
                    break;
                // break permet de casser la boucle si le cas est true
                case 1 :
                    Debug.Log("La semaine ne fait que commencer");
                    break;
                case 2 :
                    Debug.Log("C'est le milieu de la semaine");
                    break;
                case 3 :
                    Debug.Log("bientot le weekend");
                    break;
                case 4 :
                    Debug.Log("c'est le weekend !!");
                    break;
                case 5 :
                    Debug.Log("profite ma poule il te reste 40 ans a tirer");
                    break;
                case 6 :
                    Debug.Log("prepare toi pour demain");
                    break;
                default :
                    //default est la version par default si on assigne aucune valeur ou que la valeur est plus grande que l'enum a la variable qu'on veux verifier 
                    Debug.Log("je suis en vacance je taff pas");
                    break;
            }
        }
    } 
     
}
