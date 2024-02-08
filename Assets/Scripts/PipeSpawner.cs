using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    [SerializeField] private float maxTime = 1.5f;
    [SerializeField] private float heightRange = 0.45f;
    [SerializeField] private GameObject pipe;
    private float timer;
    // Start calls the 1st pipe
    private void Start()
    {
        spawnPipe();
    }
    //spawns the pipes when the timer hits the maximum time
    private void Update()
    {
        if(timer > maxTime)
        {
            spawnPipe();
            timer = 0;
        }
        timer += Time.deltaTime;
    }
    // SpawnPipe spawns the pipe
    private void spawnPipe()
    {
        Vector3 spawnRate = transform.position + new Vector3(0, Random.Range(-heightRange, heightRange));
        GameObject pipeSpawn = Instantiate(pipe, spawnRate, Quaternion.identity);

        Destroy(pipeSpawn, 10f);
    }
}
