using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenOnOrientation : MonoBehaviour
{
    public BoxCollider2D collision;
    public GameObject rendering;
    public bool isHorizontal = true;
    // Update is called once per frame
    void Update()
    {
        if ((Mathf.Abs(Physics2D.gravity.x) > Mathf.Abs(Physics2D.gravity.y)) == isHorizontal) { 
            collision.enabled = false;
            rendering.active = false;
        }
        else
        {
            collision.enabled = true;
            rendering.active = true;
        }
    }
}
