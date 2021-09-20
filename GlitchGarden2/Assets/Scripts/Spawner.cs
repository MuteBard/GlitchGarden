using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] bool shouldSpawn = true;
    [SerializeField] float spawnRateMin = 3;
    [SerializeField] float randomnessRange = 5;
    [SerializeField] GameObject attacker;
    [SerializeField] GameObject parentContainer;

    IEnumerator Start()
    {
        do{
            yield return StartCoroutine(spawnAttacker());
        } while (shouldSpawn);
    }

    IEnumerator spawnAttacker(){
        var newEnemy = Instantiate(attacker, transform.position, transform.rotation, parentContainer.transform);
        newEnemy.transform.localScale = new Vector3(170,170,170);
        float spawnRate = Random.Range(spawnRateMin, spawnRateMin + randomnessRange);
        yield return new WaitForSeconds(spawnRate);
    }

    
}
