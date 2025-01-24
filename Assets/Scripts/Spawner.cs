using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float timeToSpawn, minYPosition, MaxYPosition;
    public float maxtimeToSpawn = 0.8f;
    public GameObject spawnPrefab;
    private float timer;
    private int counter = 0;
    public int difficultIncreese = 4;

    private void Update()
    {
        if (timer <= 0)
        {
            counter++;
            timer = timeToSpawn;
            GameObject Pipe = Instantiate(spawnPrefab, transform.position, Quaternion.identity);
            float range = Random.Range(minYPosition, MaxYPosition);
            Pipe.transform.position = new Vector3(Pipe.transform.position.x, range, 0);
            Destroy(Pipe, 15);
            if ((counter > difficultIncreese) && (timeToSpawn > maxtimeToSpawn))
            {
                counter = 0;
                timeToSpawn = timeToSpawn - 0.2f;
            }
        }
        else
        {
            timer -= Time.deltaTime;
        }
    }
}
