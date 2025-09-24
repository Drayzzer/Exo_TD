using UnityEngine;

namespace EnumerationEtSwitch
{
    public class Ex1 : MonoBehaviour
    {
        enum DaysOfWeek { Lundi, Mardi, Mercredi, Jeudi, Vendredi, Samedi, Dimanche }
        //enum est le mot clé pour déclarer une énumeration 
        // DaysOfWeek est le nom de la déclaration
        // { est le caractère d'ouverture et } permet de fermer 
        // {} il y a tout ce qu'on veux énumerer
        // c'est une énumeration qui permet lister tout ce qu'ont met dedans

        void Start()
        {
            DaysOfWeek today = DaysOfWeek.Lundi;
            // DaysOfWeek est le type de la variable
            // today est le nom de la variable
            // = est un opérateur d'assignation qui assigne la valeur de droite a celui de gauche
            // () est un opérateur qui comporte un parametre
            // ce qu'il y a dans () est le type qu'on appelle pour l'assigner a today
            // cette variable permet d'assigner le type DaysOfWeek a today et la valeur 4
            // permet de donner a 4 le type DaysOfWeek
            Debug.Log("Aujourd'hui nous sommes" + today);
        }
    } 
}
