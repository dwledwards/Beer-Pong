using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{
    public Text CounterText;

    private int Count = 0;

    private GameObject cup;

    private void Start()
    {
        Count = 0;
    }

    public void UpdateCOunter()
    {
        Count += 1;
        CounterText.text = "Count : " + Count;
    }
}
