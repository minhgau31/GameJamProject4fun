using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawn : MonoBehaviour
{

    //Types of bullet
    public GameObject perfectBulletPrefab;
    public GameObject goodBulletPrefab;
    public GameObject normalBulletPrefab;



    //Weapon Spawn position
    public Transform weaponSpawn;
    
    //Referencing the game manager
    public GameManager gameManager;

    //Can the player shoot
    public bool canShoot = false;

    public PlayerBehavior playerBehavior;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Space) && canShoot == true && playerBehavior.ableToShoot == true)
        {
            Debug.Log("Shoot");
            Shoot();
            
        }

    }

    void Shoot()
    {
        if (gameManager.perfectHit == true)
        {
            
            Debug.Log("spawning Perfect Hit");
            Instantiate(perfectBulletPrefab, weaponSpawn.position, weaponSpawn.rotation);
            
        }

        if (gameManager.goodHit == true)
        {
            
            Debug.Log("spawning Good Hit");
            Instantiate(goodBulletPrefab, weaponSpawn.position, weaponSpawn.rotation);
            
        }

        if (gameManager.normalHit == true)
        {
            
            Debug.Log("spawning Normal Hit");
            Instantiate(normalBulletPrefab, weaponSpawn.position, weaponSpawn.rotation);
            
        }

        if (gameManager.noHit == true)
        {
            
            Debug.Log("KEKW");
        }
    }
}
