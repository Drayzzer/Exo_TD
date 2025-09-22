using UnityEngine;

namespace InteractionEtManipulation
{
    public class Ex1 : MonoBehaviour
    {
        public Color LeftClickColor;
        public Color RightClickColor;
        void Update()
        {
            if (Input.GetButtonDown ("Fire1"))
            {
                gameObject.GetComponent<MeshRenderer>().material.color = LeftClickColor;
            }

            if (Input.GetButtonDown("Fire2"))
            {
                gameObject.GetComponent<MeshRenderer>().material.color = RightClickColor;
            }
        }
    }
}

