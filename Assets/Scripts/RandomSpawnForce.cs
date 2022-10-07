using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawnForce : MonoBehaviour
{
    public GameObject lanternPrefab;
    public Transform lanternSpawnPoint;
    public float timeToFloat;
    float timer;
    public int lanternSpawnMax;
    private int lantermSpawn;
    public float lanternSpeed;


    // Update is called once per frame
    void Update()
    {
        timer = timer + Time.deltaTime;
        if (timer >= timeToFloat)
        {
            timer = 0f;
            lantermSpawn = lantermSpawn + 1;
            Vector3 randomSpawnPosition = new Vector3(transform.position.x + Random.Range(-10, 11), transform.position.y, transform.position.z + Random.Range(-10, 11));
            GameObject lanternInstance = Instantiate(lanternPrefab, randomSpawnPosition, Quaternion.identity);
            lanternInstance.GetComponent<Rigidbody>().AddForce(lanternSpawnPoint.up * lanternSpeed, ForceMode.Impulse);
            
        }
    }
}
