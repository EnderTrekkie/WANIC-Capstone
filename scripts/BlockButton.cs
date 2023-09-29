using Newtonsoft.Json.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockButton : MonoBehaviour
{
    public Door[] doors;
    public SpriteRenderer draw;
    public Sprite pressedImg;
    public Sprite normImg;

    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.CompareTag("Block")) {
            foreach (Door door in doors) {
                door.ToggleDoor(false);
                draw.sprite = pressedImg;
            }
        }
    }
    private void OnTriggerExit2D(Collider2D collision) {
        if (collision.CompareTag("Block")) {
            foreach (Door door in doors) {
                door.ToggleDoor(true);
                draw.sprite = normImg;
            }
        }
    }
}
