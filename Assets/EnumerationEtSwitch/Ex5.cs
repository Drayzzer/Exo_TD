using System.Collections.Generic;
using UnityEngine;

namespace EnumerationEtSwitch
{
    public enum EnemyType {Goblin, Orc, Troll, Dragon }
    public class Ex5 : MonoBehaviour
    {
        public List<EnemyType> enemyList = new List<EnemyType>();
        void Start()
        {
            foreach ( EnemyType enemy in enemyList)
            {
                switch (enemy)
                {
                    case 0:
                        Debug.Log("petit et relou");
                        break;
                    case (EnemyType)1:
                        Debug.Log("sac a pv");
                        break;
                    case (EnemyType)2:
                        Debug.Log("trop puissant mais pas beau");
                        break;
                    case (EnemyType)3:
                        Debug.Log("le style a l'état pur");
                        break;
                }
            }
        }
    }
}

