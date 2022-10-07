using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawnForce : MonoBehaviour
{
    public Rigidbody lanternPrefab;
    public Transform lanternSpawnPoint;
    public float timeToFloat;
    float timer;
    public int lanternSpawnMax;
    private int lantermSpawn;


    void Start()
    {
        lanternPrefab = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        timer = timer + Time.deltaTime;
        if (timer >= timeToFloat)
        {
            timer = 0f;
            lantermSpawn = lantermSpawn + 1;
            Rigidbody lanternInstance;
            Vector3 randomSpawnPosition = new Vector3(Random.Range(-10, 11), Random.Range(5, 15), Random.Range(-10, 11));
            lanternInstance = Instantiate(lanternPrefab, randomSpawnPosition, Quaternion.identity);
            lanternInstance.AddForce(lanternSpawnPoint.up * 100);
            
        }
    }
}
