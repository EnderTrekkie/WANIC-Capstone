using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aligner : MonoBehaviour
{
    public float targetAngle;
    public float speed;
    // Update is called once per frame
    void Update()
    {
        float curAngle = transform.rotation.eulerAngles.z;
        //rotate towards target angle at constant speed
        transform.rotation = Quaternion.Euler(0,0,Mathf.LerpAngle(curAngle, targetAngle,speed/Mathf.Abs(curAngle-targetAngle)));
    }
}
