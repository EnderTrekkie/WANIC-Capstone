using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlPlayer : MonoBehaviour
{
    public Rigidbody2D RB;
    public bool IsVertical = false;
    public float moveAcc = 50;
    public float maxSpeed = 5;
    // Update is called once per frame
    void Update()
    {
        //direction player is able to go (either up/down or left/right)
        Vector2 dir = new Vector2(IsVertical ? 0 : 1, IsVertical ? 1 : 0);
        //input vector
        Vector2 control = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        //move vector for player
        Vector2 move = Vector2.Scale(dir, control) * moveAcc / Time.deltaTime;

        RB.AddForce(move);

    }
}
