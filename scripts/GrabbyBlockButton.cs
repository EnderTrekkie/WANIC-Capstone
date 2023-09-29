using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabbyBlockButton : MonoBehaviour {
    public Door[] doors;
    public Transform GrabPoint;
    private bool activated;
    public SpriteRenderer draw;
    public Sprite pressedImg;

    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.CompareTag("Block") && !activated) {
            foreach (Door door in doors) {
                door.ToggleDoor(false);
                draw.sprite = pressedImg;
            }
            collision.tag = "LockedBlock";
            activated = true;
        }
    }
    private void OnTriggerStay2D(Collider2D collision) {
        if (collision.CompareTag("LockedBlock")) {
            collision.attachedRigidbody.velocity = Vector3.zero;
            collision.transform.position = GrabPoint.position;
        }
    }
}
