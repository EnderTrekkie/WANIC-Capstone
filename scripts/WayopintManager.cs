using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayopintManager : MonoBehaviour
{
    private Vector3 pos;
    private Quaternion rot;
    private Vector2 grav = Vector2.down;
    public controlGravity GravControl;
    public Transform player;
    public void SetRespawn(Vector3 setPos, Quaternion setRot, Vector2 setGrav) {
        pos = setPos;
        rot = setRot;
        grav = setGrav;
    }
    public void Respawn() {
        player.position = pos;
        player.rotation = rot;
        player.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        GravControl.UpdateGravity(grav);
    }
}
