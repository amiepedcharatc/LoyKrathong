using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestMove : MonoBehaviour
{
    bool hasFlown = false;
    public GameObject prefab;
    public float timeToFly;
    float timer;
    public int lanternToSpawn;
    private int lanternMax;

    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (lanternMax >= lanternToSpawn) return;

        timer = timer + Time.deltaTime;
        if (timer >= timeToFly)
        {
            timer = 0f;
            lanternMax = lanternMax + 1;
            Vector3 randomSpawnPosition = new Vector3(Random.Range(-4, 5), Random.Range(0, 5), Random.Range(-4, 5));
            Instantiate(prefab, randomSpawnPosition, Quaternion.identity);
        }
    }

}
