using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

[ExecuteInEditMode]
public class CheckerboardGeneration : MonoBehaviour
{
    [Range(0.1f, 2f)]
    public float rozmiarKafelka = 1;

    public int szerokosc = 2;
    public int wysokosc = 1;

    public bool generujMape;

    MeshRenderer meshRenderer;
    MeshFilter meshFilter;

    List<Vector3> verts =  new List<Vector3>();
    List<int> tris =   new List<int>();
    List<Vector3> normals= new List<Vector3>();
    List<Vector2> uvs =    new List<Vector2>();

    Mesh mesh;


    void Update()
    {
        if(generujMape)
        {
            generujMape = false;

            //Refreshowanie componentow
            if(gameObject.GetComponent<MeshRenderer>())
            {
                DestroyImmediate(gameObject.GetComponent<MeshRenderer>());
                meshRenderer = gameObject.AddComponent<MeshRenderer>();
            }
            else
                meshRenderer = gameObject.AddComponent<MeshRenderer>();

            //Refreshowanie componentow
            if (gameObject.GetComponent<MeshFilter>())
            {
                DestroyImmediate(gameObject.GetComponent<MeshFilter>());
                meshFilter = gameObject.AddComponent<MeshFilter>();
            }
            else
                meshFilter = gameObject.AddComponent<MeshFilter>();

            if(gameObject.GetComponent<Mesh>())
            {
                Destroy(GetComponent<Mesh>());
                mesh = new Mesh();
            }
            else
                mesh = new Mesh();

            for (int x = 0; x < szerokosc; x++)
            {
                for (int y = 0; y < wysokosc; y++)
                {

                    //verts.Add(new Vector3(x * (rozmiarKafelka * 2), y * (rozmiarKafelka * 2)));
                    //verts.Add(new Vector3(x * (rozmiarKafelka * 2) + rozmiarKafelka, y * (rozmiarKafelka * 2)));
                    //verts.Add(new Vector3(x * (rozmiarKafelka * 2), y * (rozmiarKafelka * 2) + rozmiarKafelka));
                    //verts.Add(new Vector3(x * (rozmiarKafelka * 2) + rozmiarKafelka, y * (rozmiarKafelka * 2) + rozmiarKafelka));

                    verts.Add(new Vector3(x * (rozmiarKafelka * 2)                 , y * (rozmiarKafelka * 2)                 ));
                    verts.Add(new Vector3(x * (rozmiarKafelka * 2)                 , y * (rozmiarKafelka * 2) + rozmiarKafelka));
                    verts.Add(new Vector3(x * (rozmiarKafelka * 2) + rozmiarKafelka, y * (rozmiarKafelka * 2)                 ));
                    verts.Add(new Vector3(x * (rozmiarKafelka * 2) + rozmiarKafelka, y * (rozmiarKafelka * 2) + rozmiarKafelka));


                    tris.Add(x * y * 3);
                    tris.Add(x * y * 3 + 1);
                    tris.Add(x * y * 3 + 2);

                    normals.Add(-Vector3.forward);
                    normals.Add(-Vector3.forward);
                    normals.Add(-Vector3.forward);
                    normals.Add(-Vector3.forward);

                    uvs.Add(new Vector2(0, 0));
                    uvs.Add(new Vector2(0, 0));
                    uvs.Add(new Vector2(0, 0));
                    uvs.Add(new Vector2(0, 0));
                }
            }
            mesh.vertices = verts.ToArray();
            mesh.normals = normals.ToArray();
            mesh.triangles = tris.ToArray();
            mesh.uv = uvs.ToArray();

            meshFilter.mesh = mesh;
        }
    }
}