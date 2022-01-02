using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Transform spawnerTransform;
    [SerializeField] private List<GameObject> pipes;
    [SerializeField] private float spawnSpeed = 1f;
    [SerializeField] private int pipeIndexToSpawn = 0;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnPipe());
    }

    // Update is called once per frame
    void Update()
    {
         
    }

    IEnumerator SpawnPipe()
    {
        if (pipeIndexToSpawn == pipes.Count - 1)
        {
            pipes[pipeIndexToSpawn].gameObject.transform.position = new Vector2(spawnerTransform.position.x, Random.Range(-1f, 3.25f));
            Debug.Log(pipes[pipeIndexToSpawn].transform.position.y);
            pipeIndexToSpawn++;
            pipeIndexToSpawn = 0;
        }

        else
        {
            pipes[pipeIndexToSpawn].gameObject.transform.position = new Vector2(spawnerTransform.position.x, Random.Range(-1f, 3.25f));
            Debug.Log(pipes[pipeIndexToSpawn].transform.position.y);
            pipeIndexToSpawn++;
        }
        
        yield return new WaitForSeconds(spawnSpeed);
        StartCoroutine(SpawnPipe());
    }
}

