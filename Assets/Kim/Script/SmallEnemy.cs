using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallEnemy : MonoBehaviour
{

    

    public PlayerBehavior playerBehavior;

    void Update()
    {
       
      
       
        Destroy(gameObject, 4.0f);
        
      

    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "PerfectBullet")
        {
            playerBehavior.ableToShoot = false;
            Debug.Log("Hit by Perfect Bullet");
            Destroy(gameObject);
           

        }

        else if (collision.gameObject.tag == "GoodBullet")
        {
            playerBehavior.ableToShoot = false;
            Debug.Log("Hit by Good Bullet");
            Destroy(gameObject);
           
        }

        else if (collision.gameObject.tag == "NormalBullet")
        {
            playerBehavior.ableToShoot = false;
            Debug.Log("Hit by Normal Bullet");
            Destroy(gameObject);
           
        }
    }
}
