using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnenmySpawner : MonoBehaviour
{
    public PlayerBehavior pb;
    public bool spawnEnemy = true;
    public GameObject smallEnemy;
    public GameObject mediumEnemy;
    public PlayerBehavior playerBehavior;
    // Start is called before the first frame update
    public void Start()
    {
        //if (spawnEnemy == true)
        //{
        //    Invoke("spawnEnemy", 1.0f);
        //    StartCoroutine(SpawnEnemies());
        //}

        //StartCoroutine(SpawnEnemies());
    }

    // Update is called once per frame
    void Update()
    {
        if(playerBehavior.ableToShoot==true)
        {
            StartCoroutine(SpawnEnemies());
        }
    }

    IEnumerator SpawnEnemy (GameObject enemy, float time, int amount, float rateOfFire)
    {
        for (int i = 0; i < amount; i++)
        {
            yield return new WaitForSeconds(time);
            GameObject latestEnemy = Instantiate(enemy);
            latestEnemy.GetComponentInChildren<EnemyBulletSpawn>().fireRate = rateOfFire;
        }
    }

    IEnumerator SpawnEnemies()
    {
        yield return new WaitForSeconds(1.5f);
        StartCoroutine(SpawnEnemy(smallEnemy, 1.5f, 10, 3));
        
        
    }
}
