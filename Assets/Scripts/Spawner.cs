using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float timeToSpawn, minYPosition, MaxYPosition;
    public GameObject spawnPrefab;
    private float timer;


    private void Update()
    {
        if (timer <= 0)
        {
            timer = timeToSpawn;
            GameObject Pipe = Instantiate(spawnPrefab, transform.position, Quaternion.identity);
            float range = Random.Range(minYPosition, MaxYPosition);
            Pipe.transform.position = new Vector3(Pipe.transform.position.x, range, 0);
        }
        else
        {
            timer -= Time.deltaTime;
        }
    }
}
