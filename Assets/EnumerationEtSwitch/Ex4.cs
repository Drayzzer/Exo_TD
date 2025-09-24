using UnityEngine;

namespace EnumerationEtSwitch
{
    enum Season { Printemps, Ete, Automne, Hiver }
    public class Ex4 : MonoBehaviour
    {
        void Start()
        {
            Season season = Season.Printemps;
            for (int i = 0; i < 10; i++)
            {
                if (i == 3)
                {
                    Debug.Log("pause au printemps");
                    continue;
                }

                if (i == 6)
                {
                    Debug.Log("Fin prématuré en été a cause du déreglement climatique qui va nous menez a notre perte et on va tous mourir mais en fait c'est faux car c'est un complot de l'état");
                    break;
                }

                switch (i % 4)
                { 
                    case 0:
                        season = Season.Printemps;
                        break;
                    case 1:
                        season = Season.Ete;
                        break;
                    case 2:
                        season = Season.Automne;
                        break;
                    case 3:
                        season = Season.Hiver;
                        break;
                    default:
                        Debug.Log("Erreur");
                        break;
                }
            }
            
            Debug.Log(season);
        }
    }
}    