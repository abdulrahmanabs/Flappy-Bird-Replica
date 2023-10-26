using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    float spawnRate = 1.5f;
    float minHeight = -4, maxHeight = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating(nameof(SpawnPipe), 1, spawnRate);
    }

    // Update is called once per frame

    void SpawnPipe()
    {
        if (GameManager.instance.gameState != GameManager.GameState.Play)
            return;
        GameObject pipe = ObjectPooler.instance.GetPooledObject();
        pipe.transform.position = new Vector2(4, Random.Range(minHeight, maxHeight));
        pipe.gameObject.SetActive(true);
    }
}
