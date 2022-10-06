using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestMove : MonoBehaviour
{
    bool hasFlown = false;
    public GameObject[] prefab;
    public float timeToFloat;
    float timer;
    public int lanternToSpawnMin;
    private int lanternToSpawnMax;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (lanternToSpawnMax >= lanternToSpawnMin) return;

        timer = timer + Time.deltaTime;
        if (timer >= timeToFloat)
        {
            timer = 0f;
            lanternToSpawnMax = lanternToSpawnMax + 1;
            int randomIndex = Random.Range(0, prefab.Length);
            Vector3 randomSpawnPosition = new Vector3(Random.Range(-10, 11), Random.Range(5, 15), Random.Range(-10, 11));
            Instantiate(prefab[randomIndex], randomSpawnPosition, Quaternion.identity);
        }
    }

}
