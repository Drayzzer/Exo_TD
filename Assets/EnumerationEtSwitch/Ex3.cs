using UnityEngine;

namespace EnumerationEtSwitch
{
    public enum GameState { Menu, Playing, Paused, GameOver}
    public class Ex3 : MonoBehaviour
    {
        public GameState _currentState;
       
        void Update()
        {
            switch (_currentState)
            {
                case 0 :
                    Debug.Log("Menu");
                    break;
                case (GameState) 1 :
                    Debug.Log("Playing");
                    break;
                case (GameState) 2 :
                    Debug.Log("Paused");
                    break;
                case (GameState)3 :
                    Debug.Log("GameOver");
                    break;
                default:
                    Debug.Log("j'attend");
                    break;
            }
        }
    }  
}

