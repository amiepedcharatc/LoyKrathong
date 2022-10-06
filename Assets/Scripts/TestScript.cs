using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    bool lightIsOn = false;
    public float timeToStart;
    public GameObject prefab;
    float timer;

    // Start is called before the first frame update
    void Start()
    {
       
    }

// Update is called once per frame
void Update()
    {
        timer = timer + Time.deltaTime;
        if (timer >= timeToStart)
        {
            Instantiate(prefab).GetComponent<Light>().intensity = 1f;
            lightIsOn = true; 
        }
    }
}
