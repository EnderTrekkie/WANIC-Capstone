using System.Collections;
using System.Collections.Generic;
using TMPro.SpriteAssetUtilities;
using UnityEngine;

public class PlayerButton : MonoBehaviour
{
    public Door[] doors;
    public SpriteRenderer draw;
    public Sprite pressedImg;
    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.CompareTag("Player")) {
            foreach (Door door in doors) {
                door.ToggleDoor(false);
                draw.sprite = pressedImg;
            }
        }
    }
}
