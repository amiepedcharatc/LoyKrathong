using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestColor : MonoBehaviour
{
    public MeshRenderer meshRenderer; 

    void Start()
    {
        meshRenderer.material.color = Random.ColorHSV();
    }

    // Update is called once per frame

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            changeColor();
        }
    }
    void changeColor()
    {
        meshRenderer.material.color = Random.ColorHSV();
    }
}
