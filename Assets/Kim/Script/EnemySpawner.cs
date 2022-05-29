using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    public GameObject smallEnemy;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnEnemies());
    }

    IEnumerator SpawnEnemies()
    {
        yield return new WaitForSeconds(10f);
        StartCoroutine(SpawnEnemy(smallEnemy, 2.0f, 5, 3));
        yield return new WaitForSeconds(0.5f);
        StartCoroutine(SpawnEnemy(smallEnemy, 2.0f, 5, 3));
        yield return new WaitForSeconds(0.5f);
        StartCoroutine(SpawnEnemy(smallEnemy, 2.0f, 5, 3));
        yield return new WaitForSeconds(0.5f);
        StartCoroutine(SpawnEnemy(smallEnemy, 2.0f, 5, 3));
        yield return new WaitForSeconds(0.5f);
        StartCoroutine(SpawnEnemy(smallEnemy, 2.0f, 5, 3));
        yield return new WaitForSeconds(2.5f);
        StartCoroutine(SpawnEnemy(smallEnemy, 2.0f, 10, 3));
    }

    IEnumerator SpawnEnemy (GameObject enemy, float time, int amount, float rateOfFire)
    {
        for (int i = 0; i < amount; i++)
        {
            GameObject latestEnemy = Instantiate(enemy);
            yield return new WaitForSeconds(time);
            latestEnemy.GetComponentInChildren<EnemyBulletSpawn>().fireRate = rateOfFire;
        }
    }

}
