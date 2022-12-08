using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diamond : MonoBehaviour
{
    Vector3 V0, V1, V2, V3, V4, V5;
    Vector3[] newVertices;
    int[] newTriangles;
    // Start is called before the first frame update
    void Start()
    {

        V0 = new Vector3(-0.5f, 0, -0.5f);
        V1 = new Vector3(-0.5f, 0, 0.5f);
        V2 = new Vector3(0.5f, 0, 0.5f);
        V3 = new Vector3(0.5f, 0, -0.5f);
        V4 = new Vector3(0, 1, 0);
        V5 = new Vector3(0, -1, 0); //피라미드에서 해당 정점 추가하면 다이아몬드

        newVertices = new Vector3[]
        {
                V0, V1, V2, V3, V4, V5
        };

        //배열값 설정
        newTriangles = new int[]
        {
                0, 4, 3,
                3, 4, 2,
                2, 4, 1,
                1, 4, 0,
                3, 5, 0,
                2, 5, 3,
                1, 5, 2,
                0, 5, 1,
                3, 5, 0
        };

        gameObject.AddComponent<MeshFilter>();
        gameObject.AddComponent<MeshRenderer>();

        Mesh mesh = new Mesh();
        GetComponent<MeshFilter>().mesh = mesh;
        mesh.vertices = newVertices;
        mesh.triangles = newTriangles;

        Shader DefaultShader = Shader.Find("Standard");
        Material DefaultMaterial = new Material(DefaultShader);
        gameObject.GetComponent<Renderer>().material = DefaultMaterial;

    }
}