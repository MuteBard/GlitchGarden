using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] bool shouldSpawn = true;
    [SerializeField] GameObject entity;
    [SerializeField] float spawnRateMin = 3;
    [SerializeField] float randomnessRange = 5;

    IEnumerator Start()
    {
        do{
            yield return StartCoroutine(spawnLizard());
        } while (shouldSpawn);
    }

    void Update()
    {
        
    }

    IEnumerator spawnLizard(){
        var newEnemy = Instantiate(entity, transform.position, transform.rotation);
        float spawnRate = Random.Range(spawnRateMin, spawnRateMin + randomnessRange);
        yield return new WaitForSeconds(spawnRate);
    }

    
}
