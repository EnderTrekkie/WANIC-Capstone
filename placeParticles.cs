using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class placeParticles : MonoBehaviour
{
    private Camera cam;
    public Vector2 pos;
    public float z;
    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos2 = new Vector3(pos.x*cam.pixelWidth,pos.y * cam.pixelHeight, z);
        transform.position = cam.ScreenToWorldPoint(pos2);
    }
}
