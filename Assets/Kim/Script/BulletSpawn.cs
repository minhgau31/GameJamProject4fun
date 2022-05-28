using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawn : MonoBehaviour
{

    public Transform weaponSpawn;
    public GameObject bulletPrefab;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("asasa");
            Debug.Log("Shoot");
            Shoot();
        }

    }

    void Shoot()
    {
        // Create a bullet at the weapon spawn position and shoot it out
        Instantiate(bulletPrefab, weaponSpawn.position, weaponSpawn.rotation);
    }
}
