using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

[ExecuteInEditMode]
public class CheckerboardGeneration : MonoBehaviour
{
    [Range(0.1f, 2f)]
    public float rozmiarKafelka;

    public int szerokosc = 2;
    public int wysokosc = 1;

    public bool generujMape;

    Vector3[] vertices;
    List<Vector3> normals = new List<Vector3>();
    List<Vector2> uvs =    new List<Vector2>();

    Mesh mesh;


    private void OnDrawGizmosSelected()
    {
        foreach (Vector3 vert in vertices)
        {
            Gizmos.DrawSphere(vert, 0.1f);
        }
    }

    void Update()
    {
        if(generujMape)
        {
            generujMape = false;

            GetComponent<MeshFilter>().mesh = mesh = new Mesh();
            mesh.name = "Procedural Grid";

            vertices = new Vector3[(szerokosc + 1) * (wysokosc + 1)];
            for (int i = 0, y = 0; y <= wysokosc; y++)
            {
                for (int x = 0; x <= szerokosc; x++, i++)
                {
                    vertices[i] = new Vector3(x * rozmiarKafelka, y * rozmiarKafelka);
                }
            }
            mesh.vertices = vertices;

            int[] triangles = new int[szerokosc * wysokosc * 6];

            int[] subTriangles1 = new int[szerokosc * wysokosc * 3];
            int[] subTriangles2 = new int[szerokosc * wysokosc * 3];

            int n = 0;
            for (int ti = 0, vi = 0, y = 0; y < wysokosc; y++, vi++)
            {
                for (int x = 0; x < szerokosc; x++, ti += 6, vi++)
                {
                    if(n % 2 == 0)
                    {
                        triangles[ti] = vi;
                        triangles[ti + 3] = triangles[ti + 2] = vi + 1;
                        triangles[ti + 4] = triangles[ti + 1] = vi + szerokosc + 1;
                        triangles[ti + 5] = vi + szerokosc + 2;
                    }
                    else
                    {
                        triangles[ti] = vi;
                        triangles[ti + 3] = triangles[ti + 2] = vi + 1;
                        triangles[ti + 4] = triangles[ti + 1] = vi + szerokosc + 1;
                        triangles[ti + 5] = vi + szerokosc + 2;
                    }
                    n++;
                }
            }

            mesh.triangles = triangles;
        }
    }
}