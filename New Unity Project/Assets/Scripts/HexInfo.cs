using UnityEngine;
using System.Collections;

public class HexInfo : MonoBehaviour
{
    // basic hexgon mesh making
    public Vector3[] vertices;
    public Vector2[] uv;
    public int[] triangles;
    public Texture texture; //add this texture field to the top near the other fields for testing our UV coords

    // Use this for initialization
    void Start ()
    {
        MeshSetup();
    }

    void MeshSetup()
    {
        // region verts
        float floor_level = 0;

        vertices = new Vector3[] // has to be clockwise
        {
            new Vector3 (-1f, floor_level, -0.5f), // 0
            new Vector3 (-1f, floor_level, 0.5f), // 1
            new Vector3 (0f, floor_level, 1f), // 2
            new Vector3 (1f, floor_level, 0.5f), // 3
            new Vector3 (1f, floor_level, -0.5f), // 4
            new Vector3 (0f, floor_level, -1f) // 5
		};
        // endregion

        // ragion triangles
        triangles = new int[]
        {
            1, 5, 0,
            1, 4, 5,
            1, 2, 4,
            2, 3, 4
        };
        // endregion

        // region uv
        uv = new Vector2[]
        {
            new Vector2(0,0.25f), // 0
            new Vector2(0,0.75f), // 1
            new Vector2(0.5f,1), // 2
            new Vector2(1,0.75f), // 3
            new Vector2(1,0.25f), // 4
            new Vector2(0.5f,0), // 5
        };
        // endregion

        // region finalize
		MeshFilter meshFilter = gameObject.AddComponent<MeshFilter>(); //add a mesh filter to the GO the script is attached to; cache it for later
		gameObject.AddComponent<MeshRenderer>(); //add a mesh renderer to the GO the script is attached to

        //create a mesh object to pass our data into
        Mesh mesh = new Mesh();
        mesh.vertices = vertices; //add our vertices to the mesh
        mesh.triangles = triangles; //add our triangles to the mesh
        mesh.uv = uv; //add out UV coordinates to the mesh

        mesh.RecalculateNormals(); //make it play nicely with lighting
		meshFilter.mesh = mesh; //set the GO's meshFilter's mesh to be the one we just made

        GetComponent<Renderer>().material.mainTexture = texture; //UV TESTING
        // endregion
    }

    //void Update () {}
}
