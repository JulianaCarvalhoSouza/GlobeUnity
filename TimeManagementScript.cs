using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeManagementScript : MonoBehaviour
{
    [Serializable]
    public struct time { public int d, m, a; }
    public time[] sampleTimes;
    [HideInInspector]
    public static time currentTime;
    [SerializeField]
    Slider timeSlider;
    [SerializeField]
    Text dateText;

    // Start is called before the first frame update
    void Start()
    {
        timeSlider.maxValue = sampleTimes.Length-1;
        currentTime = sampleTimes[0];
        changeDateText(currentTime);
    }

    public void changeDate()
    {
        currentTime = sampleTimes[(int)timeSlider.value];
        changeDateText(currentTime);
    }

    void changeDateText(time t)
    {
        dateText.text = t.d.ToString("00") + "/" + t.m.ToString("00") + "/" + t.a.ToString("0000");
    }
}
