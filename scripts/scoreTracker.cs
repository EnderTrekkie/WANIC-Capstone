using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class scoreTracker : MonoBehaviour
{
    public float score;
    private float prevScore;
    public Text[] texts;
    public GameObject obj;
    public ParticleSystem particles;

    private void Start() {
        prevScore = score;
    }
    // Update is called once per frame
    void Update()
    {
        if (prevScore > score) {
            particles.Play();
        }
        foreach (Text text in texts) {
            text.text = score.ToString();
            if (score == 0) {
                obj.SetActive(true);
            }
        }
        prevScore = score;
    }
}
