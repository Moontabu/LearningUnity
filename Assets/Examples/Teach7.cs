using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teach7 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public Transform a;
    
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            a.position = a.position + Vector3.up;
        }

    }
}
