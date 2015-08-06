using UnityEngine;
using System.Collections;

public class HexInfo : MonoBehaviour 
{
    // basic hexgon mesh making
    public Vector3[] vertices;
    public Vector2[] uv;
    public int[] triangles;

    // Use this for initialization
    void Start () {
    }

    void MeshSetup() {
        // region verts
        floor_level = 0;
        vertices = new Vector3[] { // has to be clockwise
            new Vector3 (-1f, floor_level, -0.5f),
            new Vector3 (-1f, floor_level, 0.5f),
            new Vector3 (0f, floor_level, 1f),
            new Vector3 (1f, floor_level, 0.5f),
            new Vector3 (1f, floor_level, -0.5f),
            new Vector3 (0f, floor_level, -1f)
		};
        // endregion
        
        // ragion triangles
        // endregion
        
        // region uv
        // endregion
        
        // region finalize
        // endregion
    } 


    // Update is called once per frame
    //    void Update () {
    //}
}
