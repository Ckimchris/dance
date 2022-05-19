﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class SliderTimer : MonoBehaviour
{
    public Slider test;

    // Start is called before the first frame update
    void Start()
    {
        test.maxValue = gameObject.GetComponent<AudioSource>().clip.length;
    }

    // Update is called once per frame
    void Update()
    {
        test.value = gameObject.GetComponent<AudioSource>().time;
    }
}
