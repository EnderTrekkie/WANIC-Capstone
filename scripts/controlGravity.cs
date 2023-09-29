using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlGravity : MonoBehaviour
{
    public scoreTracker score;
    public float gravityScale = 1;
    public Transform player;
    public bool KeyCheck = false;
    public AudioSource sound;
    private void Start() {
        Physics2D.gravity = Vector2.down*gravityScale;
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Jump") > 0 && !KeyCheck && score.score>0) {
            UpdateGravity(-Physics2D.gravity);
            score.score--;
            sound.Play();
        }
        KeyCheck = Input.GetAxis("Jump") > 0;
    }
    public void UpdateGravity(Vector2 dir) {
        Physics2D.gravity = dir.normalized * gravityScale;
        float rotationZ = Mathf.Atan2(dir.x,-dir.y)*Mathf.Rad2Deg;
        player.GetComponent<PlayerRun>().IsVertical = Mathf.Abs(dir.y) < Mathf.Abs(dir.x);
    }
}
