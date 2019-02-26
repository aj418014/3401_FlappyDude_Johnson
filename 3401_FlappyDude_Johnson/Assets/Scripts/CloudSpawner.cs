using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudSpawner : MonoBehaviour
{
    public GameObject cloud;
    float spawnTime = 5.0f;
    public float spawnXPosition;
    float timer;
    public float countdown = 4.23f;
    // Update is called once per frame
    float spawnYPosition = Random.Range(-3.8f, 1.8f);

    private void Start()
    {

        Instantiate(cloud, new Vector3(spawnXPosition, spawnYPosition, 0), Quaternion.identity);

        timer = Time.time + countdown;
    }
    void Update()
    {
        spawnYPosition = Random.Range(1.0f, 1.8f);
        if (Time.time > timer)
        {
            Instantiate(cloud, new Vector3(spawnXPosition, spawnYPosition, 0), Quaternion.identity);
            //Debug.Log("Spawn");
            timer = Time.time + countdown;
        }
    }
}