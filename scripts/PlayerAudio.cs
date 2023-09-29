using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAudio : MonoBehaviour
{
    public AudioSource movementSound;
    public Rigidbody2D RB;
    private float numIntersects = 0;
    public float scale = 0.1f;

    // Update is called once per frame
    void Update()
    {
        //don't make sound when floating
        if (numIntersects > 0) {
            movementSound.volume = Mathf.Clamp01(RB.velocity.magnitude * scale);
        } else {
            movementSound.volume = 0;
        }
    }
     void OnTriggerEnter2D(Collider2D other) {
        numIntersects++;
    }
     void OnTriggerExit2D(Collider2D other) {
        numIntersects--;
    }
}
