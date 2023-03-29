using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private int minBound = 5;
    [SerializeField] private int maxBound = 10;
    [SerializeField] private GameObject enemyPrefab;
    // allows an enemy prefab to be passed in


    private void Start()
    {
        StartCoroutine(enemySpawner());
        // begins coroutine
    }
    private IEnumerator enemySpawner()
    {

        while (true)
        {
            int timeToWait = Random.Range(minBound, maxBound);
            yield return new WaitForSeconds(timeToWait);
            // picks a random spawn time between 0 and 10 (this varies between spawners)
            

            GameObject enemyToSpawn = enemyPrefab;
            Instantiate(enemyToSpawn, transform.position, Quaternion.identity);
            // instantiates the prefab

        }
    }


}
