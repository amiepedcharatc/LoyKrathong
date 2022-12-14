using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawnForce : MonoBehaviour
{
    public GameObject [] lanternPrefab;
    public Transform lanternSpawnPoint;
    public float timeToFloat;
    float timer;
    public int lanternSpawnMax;
    private int lanternSpawn;
    public float lanternSpeed;


    // Update is called once per frame
    void Update()
    {
        timer = timer + Time.deltaTime;
        if (timer >= timeToFloat)
        {
            timer = 0f;
            lanternSpawn = lanternSpawn + 1;
            int randomIndex = Random.Range(0, lanternPrefab.Length);
            Vector3 randomSpawnPosition = new Vector3(transform.position.x + Random.Range(-20, 55), transform.position.y, transform.position.z + Random.Range(-20, 55));
            GameObject lanternInstance = Instantiate(lanternPrefab[randomIndex], randomSpawnPosition, Quaternion.identity);
            lanternInstance.GetComponent<Rigidbody>().AddForce(lanternSpawnPoint.up * lanternSpeed, ForceMode.Impulse);
        }
    }
}
