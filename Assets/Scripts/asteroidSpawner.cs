using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class asteroidSpawner : MonoBehaviour
{
    [Header("Spawn Settings")]
    public GameObject asteroidPrefab;
    public Transform spawnOrigin;
    public float next_spawn_time;
    public Vector3 random;
    // Start is called before the first frame update
    void Start()
    {
         next_spawn_time = Time.time+1f;
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > next_spawn_time)
     {
            // spawnOrigin.position;
            random = new Vector3(0, Random.Range(-1.0F, 3.0F), 0);
            Instantiate(asteroidPrefab, random, Quaternion.identity);
 
            //increment next_spawn_time
             next_spawn_time += 1.7f;
     }
        
    }
}
