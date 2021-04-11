using System;
using UnityEngine;

namespace Examples
{
    public class Teach8 : MonoBehaviour
    {
        public GameObject go;
        public string jianjiajun;

        void SwitchGameObject()
        {
            bool state = !go.activeSelf;
            go.SetActive(state);
        }
        void Update()
        {
            if (Input.GetMouseButton(0))
            {
                SwitchGameObject();
            }
        }
    }
}