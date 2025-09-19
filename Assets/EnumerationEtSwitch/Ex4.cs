using UnityEngine;

namespace EnumerationEtSwitch
{
    enum Season { Printemps, été, Automne, Hiver }
    public class Ex4 : MonoBehaviour
    {
        void Start()
        {
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
                        Debug.Log("Printemps");
                        break;
                    case 1:
                        Debug.Log("été");
                        break;
                    case 2:
                        Debug.Log("Automne");
                        break;
                    case 3:
                        Debug.Log("Hiver");
                        break;
                    default:
                        Debug.Log("Fin");
                        break;
                } 
            }
        }
    }
}    