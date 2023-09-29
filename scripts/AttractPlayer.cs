using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttractPlayer : MonoBehaviour {
    public float speed = 1;
    public Transform axis;
    private void OnTriggerStay2D(Collider2D collision) {
        if (collision.CompareTag("Player") || collision.CompareTag("Block")) {
            collision.attachedRigidbody.AddForce((axis.position-collision.transform.position).normalized*speed);
        }
    }
}
