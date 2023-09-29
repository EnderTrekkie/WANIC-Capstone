using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItTakes2Door : MonoBehaviour
{
    public GameObject[] doors;
    public GameObject render;
    private void Update() {
        int openCount = 0;
        foreach (GameObject door in doors) {
            if (!door.active) {
                openCount++;
            }
        }
        if (openCount == doors.Length) {
            render.active = true;
        }
    }
}
