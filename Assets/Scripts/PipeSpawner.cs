using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject pipeSpawner;
    float spawnRate = 1.5f;
    float minHeight = -4, maxHeight = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating(nameof(SpawnPipe), 1, spawnRate);
    }

    // Update is called once per frame
    void Update()
    {

    }
    void SpawnPipe()
    {
        Instantiate(pipeSpawner, new Vector3(4, Random.Range(minHeight, maxHeight)), Quaternion.identity);
    }
}
