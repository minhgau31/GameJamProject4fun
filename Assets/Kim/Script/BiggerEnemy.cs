using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BiggerEnemy : MonoBehaviour
{

    public int Health = 100;




    public PlayerBehavior playerBehavior;

    void Update()
    {



       if (Health <= 0)
        {
            Destroy(gameObject);
        }



    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "PerfectBullet")
        {
            Health = Health - 50;
            Debug.Log("Hit by Perfect Bullet");
            


        }

        else if (collision.gameObject.tag == "GoodBullet")
        {
            Health = Health - 30;
            Debug.Log("Hit by Good Bullet");
            

        }

        else if (collision.gameObject.tag == "NormalBullet")
        {
            Health = Health - 15;
            Debug.Log("Hit by Normal Bullet");
            

        }
    }

}
