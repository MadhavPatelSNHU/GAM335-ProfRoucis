using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    [SerializeField] private GameObject enemyPrefab;
    [SerializeField] private float enemySpawnInterval = 1f;

    public GameObject[] spawnLocations;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawnEnemy(enemySpawnInterval, enemyPrefab));

    }


    private IEnumerator spawnEnemy(float interval, GameObject enemy)
    {
        yield return new WaitForSeconds(interval);
        GameObject newEnemy = Instantiate(enemy);
        enemy.transform.position = spawnLocations[0].transform.position;
        StartCoroutine(spawnEnemy(interval, enemy));
    }

}
