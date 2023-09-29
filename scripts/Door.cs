using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public BoxCollider2D colliderer;
    public GameObject sprite;
    public AudioSource sound;
    public bool playedAlready = false;
    public void ToggleDoor(bool state) {
        colliderer.enabled = state;
        sprite.SetActive(state);
        if (!playedAlready) {
            sound.Play();
            playedAlready = true;
        }
    }
}
