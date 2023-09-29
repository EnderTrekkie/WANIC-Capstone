using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animat : MonoBehaviour
{
    public Sprite[] sprites;
    public SpriteRenderer renderer;
    // Update is called once per frame
    void Update()
    {
        //g=down  in=0  : 0
        //g=down  in=1  : 1
        //g=down  in=-1 : 2
        //g=up    in=0  : 3
        //g=up    in=1  : 4
        //g=up    in=-1 : 5
        //g=left  in=0  : 6
        //g=left  in=1  : 7
        //g=left  in=-1 : 8
        //g=right in=0  : 9
        //g=right in=1  : 10
        //g=right in=-1 : 11

        int frame = 0;
        if (Mathf.Abs(Physics2D.gravity.y) > Mathf.Abs(Physics2D.gravity.x))
        {
            if (Input.GetAxis("Horizontal") < 0)
            {
                frame += 1;
            }
            if (Input.GetAxis("Horizontal") > 0)
            {
                frame += 2;
            }
            if (Physics2D.gravity.y > 0)
            {
                frame += 3;
            }
        }
        else {
            if (Input.GetAxis("Vertical") < 0)
            {
                frame += 1;
            }
            if (Input.GetAxis("Vertical") > 0)
            {
                frame += 2;
            }
            if (Physics2D.gravity.x > 0)
            {
                frame += 6;
            }
            else {
                frame += 9;
            }
        }
        Debug.Log(frame);
        renderer.sprite = sprites[frame];
    }
}
