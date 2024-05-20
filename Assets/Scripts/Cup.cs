using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cup : MonoBehaviour
{
    private Counter counter;
    // Start is called before the first frame update
    void Start()
    {
       counter = GameObject.Find("Counter").GetComponent<Counter>(); 
    }

    private void OnTriggerEnter(Collider other)
    {
        counter.UpdateCOunter();
        Debug.Log("triggered");
    }
}
