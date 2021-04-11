using System;
using UnityEngine;

namespace Examples
{
    public class Teach9 : MonoBehaviour

    {
        public Transform wy;

        private void Update()
        {
            if (Input.GetMouseButton(0))
            {
                wy.position = wy.position + Vector3.right;
            }
        }
    }
}