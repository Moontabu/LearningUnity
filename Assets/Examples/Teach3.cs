using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teach3 : MonoBehaviour
{
    public MeshFilter meshFilter;

    void Start()
    {
        Mesh mesh = new Mesh();
        mesh.vertices = new Vector3[] {new Vector3(0, 0, 0), new Vector3(1, 0, 0), new Vector3(0.2f, 1, 0), new Vector3(0.8f, 1, 0)};
        mesh.triangles = new[] {0, 2, 1, 2,3,1};
        mesh.uv = new[] {Vector2.zero, Vector2.right, new Vector2(0.2f, 1), new Vector2(0.8f, 1)};
        mesh.name = "JJJ";

        meshFilter.mesh = mesh;
    }
    

    // Update is called once per frame
    void Update()
    {
    }
}