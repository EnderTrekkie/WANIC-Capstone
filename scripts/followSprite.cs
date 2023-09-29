using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followSprite : MonoBehaviour
{
    public Transform player;
    public float zOffset = -1;
    public float lerpSpeed = 0.9f;
    public float maxDist = 5;
    // Update is called once per frame
    void FixedUpdate()
    {
        //lerp position to player
        transform.position = Vector3.Lerp(transform.position,player.position,lerpSpeed*Time.deltaTime);

        //lock z distance
        transform.position.Set(transform.position.x, transform.position.y, zOffset);
    }
}
