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


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Shoot");
            Shoot();
        }

    }

    void Shoot()
    {
        if (gameManager.perfectHit)
        {
            Debug.Log("Perfect Hit");
            Instantiate(perfectBulletPrefab, weaponSpawn.position, weaponSpawn.rotation);
        }

        else if (gameManager.goodHit)
        {
            Debug.Log("Good Hit");
            Instantiate(goodBulletPrefab, weaponSpawn.position, weaponSpawn.rotation);
        }

        else if (gameManager.normalHit)
        {
            Debug.Log("Normal Hit");
            Instantiate(normalBulletPrefab, weaponSpawn.position, weaponSpawn.rotation);
        }

        else if (gameManager.noHit)
        {
            Debug.Log("KEKW");
        }
    }
}
