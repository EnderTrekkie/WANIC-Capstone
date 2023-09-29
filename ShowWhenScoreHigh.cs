using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowWhenScoreHigh : MonoBehaviour
{
    public float howHigh = 30;
    public scoreTracker score;
    public Image draw;
    // Update is called once per frame
    void Update()
    {
        if (score.score > howHigh) {
            draw.enabled = true;
        }
    }
}
