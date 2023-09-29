using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class songShuffler : MonoBehaviour
{
    public AudioClip[] musics;
    public AudioSource emitter;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!emitter.isPlaying) {
            emitter.clip = musics[Random.Range(0, musics.Length - 1)];
            emitter.Play();
        }
    }
}
