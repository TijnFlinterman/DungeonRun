﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerSwitch : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        (GameObject.Find("Timer").GetComponent<Timer>().CanCount) = true;
    }
}
