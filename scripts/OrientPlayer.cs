using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrientPlayer : MonoBehaviour
{
    public Rigidbody2D RB;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //gravity of plyer
        Vector2 down = Physics2D.gravity;
        //velocity of player
        Vector2 vel = RB.velocity;
        //component of velocity perpendicular to gravity
        //a_perpendicular_b = a*sin(alpha) where alpha is angle between a and b
        Vector3 forward = vel*Mathf.Sin(Vector2.Angle(down,vel));

    }
}
