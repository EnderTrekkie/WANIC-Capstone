using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinGame : MonoBehaviour {
    public PlayerRun player;
    public GameObject Menu;
    public controlGravity grav;
    public songShuffler sound;
    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision) {
        Menu.SetActive(true);
        player.MaxSpeed = 0;
        grav.enabled = false;
        sound.enabled = false;
    }
}
