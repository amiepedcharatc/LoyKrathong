using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestColor : MonoBehaviour
{
    public MeshRenderer meshRenderer;
    public float timeToFloat;
    float timer;
    

    void Start()
    {
        meshRenderer.material.color = Random.ColorHSV();
    }

    // Update is called once per frame

    void Update()
    {
        timer = timer + Time.deltaTime;
        if (timer >= timeToFloat)
        {
            changeColor();
        }
    }
    void changeColor()
    {
        meshRenderer.material.color = Random.ColorHSV();
   
    }
}
