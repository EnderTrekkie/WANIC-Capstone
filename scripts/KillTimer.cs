using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillTimer : MonoBehaviour
{
    public float time;

    // Update is called once per frame
    void Update()
    {
        //tick time forward
        time -= Time.deltaTime;
        //if time's up
        if (time < 0) {
            //you should kill yourself, now!
            Destroy(gameObject);
        }
    }
}
