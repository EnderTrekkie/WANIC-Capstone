using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetLowScore : MonoBehaviour
{
    public Text text;
    public scoreTracker score;
    public bool newRecord = false;
    private void OnEnable() {
        if (PlayerPrefs.HasKey("score")) {
            PlayerPrefs.SetInt("score", Mathf.Max(Mathf.FloorToInt(score.score), PlayerPrefs.GetInt("score")));
        } else {
            PlayerPrefs.SetInt("score", Mathf.FloorToInt(score.score));
        }
        text.text = PlayerPrefs.GetInt("score").ToString();
        PlayerPrefs.Save();
    }
}
