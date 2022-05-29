using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    public GameObject smallEnemy;
    
    public PlayerBehavior playerBehavior;
    // Start is called before the first frame update
    void Start()
    {
      
    }
    public void Update()
    {
       if(playerBehavior.SpawnedEnemy == true)
        {
           StartCoroutine(SpawnEnemy1(smallEnemy, 6.0f, 1, 3));
            playerBehavior.SpawnedEnemy = false;

        }
    }

  

  
    IEnumerator SpawnEnemy1(GameObject enemy, float time, int amount, float rateOfFire)
    {
       
            GameObject latestEnemy = Instantiate(enemy);
           
            latestEnemy.GetComponentInChildren<EnemyBulletSpawn>().fireRate = rateOfFire;
        yield return new WaitForSeconds(time);
        playerBehavior.ableToShoot = false;

    }

}
