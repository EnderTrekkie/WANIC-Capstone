using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockRotation : MonoBehaviour
{
    public Vector2 dir = Vector2.down;
    public controlGravity gravity;
    public GameObject flasher;
    public float flashLength;
    private float flashTime;
    private void Update() {
        flashTime -= Time.deltaTime;
        if (flashTime < 0) {
            flasher.SetActive(false);
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) {
            gravity.UpdateGravity(dir);
            flasher.SetActive(true);
            flashTime = flashLength;
        }
    }
}
