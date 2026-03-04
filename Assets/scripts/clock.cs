using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class clock : MonoBehaviour
{
    [SerializeField] GameObject secondsHand;
    [SerializeField] GameObject minutesHand;
    [SerializeField] GameObject hoursHand;
    DateTime now;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        now = DateTime.Now;

        float seconds = now.Second;
        float minutes = now.Minute;
        float hours = now.Hour;
        //secondsHand.transform.Rotate(0, 0, -10 * Time.deltaTime);
        
        secondsHand.transform.rotation = Quaternion.Euler(0, 0, -seconds * 6f);
        minutesHand.transform.rotation = Quaternion.Euler(0, 0, -minutes * 6f);
        hoursHand.transform.rotation = Quaternion.Euler(0, 0, -hours * 30f - 30/60 * -minutes);
    }
}
