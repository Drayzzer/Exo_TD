using UnityEngine;

namespace GameloopEtHierarchie
{
    public class Ex2 : MonoBehaviour
    {
        void Awake() 
            //ceci est une methode void le type Awake la variable et () le parametre
        {
        Debug.Log("i'm Awake");
        // ceci est une instruction
        }

        void Start()
        {
            Debug.Log("i Start");
        }
        void OnEnable()
        {
        Debug.Log("i'm Enable");
        }

        void OnDisable()
        {
            Debug.Log("i OnDisable");
        }

        void OnDestroy()
        {
            Debug.Log("i'm Destroyed");
        }
        // tout cela est un Gameloop
        // permet d'afficher sur unity en temps réel les changement qui sont effectuer 
    }
}
