using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoints : MonoBehaviour
{
    [SerializeField] GameObject[] spawnPoints;
    [SerializeField] GameObject Enemy;
    float SpawnTimer = 5;
    public int EnemyCount;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnCloneEnemy());
    }

    // Update is called once per frame
    IEnumerator SpawnCloneEnemy()
    {
        int nextSpawnLocation = Random.Range(0, spawnPoints.Length);
        Instaniate(Enemy, spawnPoints[nextSpawnLocation].transform.position, Quanternion.identity);
        yield return new WaitForSeconds(SpawnTimer);

    }
}
