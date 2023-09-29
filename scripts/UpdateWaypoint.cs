using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateWaypoint : MonoBehaviour
{
    public WayopintManager manager;
    public ParticleSystem particles;
    public GameObject PlayerGhost;
    public Transform playerDir;
    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.CompareTag("Player")) {
            manager.SetRespawn(transform.position, transform.rotation, -transform.up);
            particles.Play();
            PlayerGhost.transform.position = transform.position;
            PlayerGhost.transform.up = playerDir.up;
            PlayerGhost.GetComponent<Aligner>().targetAngle = transform.rotation.eulerAngles.z;
        }
    }
}
