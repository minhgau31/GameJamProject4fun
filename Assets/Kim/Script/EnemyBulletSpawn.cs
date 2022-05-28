using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletSpawn : MonoBehaviour
{

    public Transform weaponSpawn;
    public GameObject bullet;

    public float fireRate = 1.5f;
    public float nextShot;

    // Start is called before the first frame update
    void Start()
    {

        nextShot = Time.time;
        Invoke("Shoot", 2.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Shoot()
    {
        if (Time.time > nextShot)
        {
            Instantiate(bullet, weaponSpawn.position, weaponSpawn.rotation);
            nextShot = Time.time + fireRate;
        }
    }

}
