using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePlayer : MonoBehaviour
{
    public controlGravity grav;
    public float rotateCooldown = 1;
    private float cooldown = 0;
    public GameObject RotationParticles;
    // Update is called once per frame
    void Update()
    {
        cooldown -= Time.deltaTime;
    }
    void rotatePlayer(Collision2D collision) {
        //make new gravity vector
        Vector2 newGrav = Quaternion.AngleAxis(90, Vector3.forward) * Physics2D.gravity;
        //rounding errors are a pain in the back
        if (Mathf.Abs(newGrav.x) < 0.01)
        {
            newGrav.Set(0, newGrav.y);
        }
        if (Mathf.Abs(newGrav.y) < 0.01)
        {
            newGrav.Set(newGrav.x, 0);
        }
        //change gravity with new vector
        grav.UpdateGravity(newGrav);
        //make particles
        Instantiate(RotationParticles,collision.transform.position,transform.rotation);
        //reset cooldown
        cooldown = rotateCooldown;
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        //detect contact with player
        if (collision.gameObject.tag == "Player" && cooldown < 0) {
            //change gravity
            rotatePlayer(collision);
        }
    }
    private void OnTriggerExit2D(Collider2D collision) {
        if (collision.gameObject.tag == "Player" && cooldown < 0) {
            cooldown = rotateCooldown;
        }
    }
}
