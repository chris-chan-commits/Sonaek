﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;

// LAST EDITED : Benjamin S
public class PointSystem : MonoBehaviour
{
    public Text CounterRef;
    public GameObject PlayerRef;
    public float Points;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        CounterRef.text = Points.ToString("Points: " + Points);
    }
}
