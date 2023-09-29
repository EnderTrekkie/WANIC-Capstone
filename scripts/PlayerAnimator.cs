using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{
    //animation tiles
    public Sprite[] tiles;
    public SpriteRenderer player;

    // Update is called once per frame
    void Update()
    {
        //defining info
        Vector2 down = Physics2D.gravity;
        Vector2 input = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

        //vars to define what frame to do
        int dir = 0;//0 = down, 1 = up, 2 = left, 3 = left
        bool leftup = false;//are we moving left or right
        bool isMoving = input.magnitude > 0;
        
        //set vars
        if (Mathf.Abs(down.x) > Mathf.Abs(down.y)) {
            //horizontal gravity
            dir = down.y > 0 ? 3 : 2;
            leftup = input.y < 0;
        } 
        else {
            //vertical gravity
            dir = down.y > 0 ? 1 : 0;
            leftup = input.x < 0;
        }

        //calculate correct frame
        //12 frames (0-11), directions are sets of 3 (4 directions)
        int frame = dir*3;
        if (isMoving) {
            if (leftup) {
                frame += 2;
            } else {
                frame += 1;
            }
        }

        //apply frame
        player.sprite = tiles[frame];
    }
}
