using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallEnemy : MonoBehaviour
{

    public int Health = 35;

    public PlayerBehavior playerBehavior;

    void Update()
    {
        if (Health <= 0)
        {
            playerBehavior.ableToShoot = false;
            Destroy(gameObject);

        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "PerfectBullet")
        {
            Debug.Log("Hit by Perfect Bullet");
            Health = Health - 35;
        }

        else if (collision.gameObject.tag == "GoodBullet")
        {
            Debug.Log("Hit by Good Bullet");
            Health = Health - 20;
        }

        else if (collision.gameObject.tag == "NormalBullet")
        {
            Debug.Log("Hit by Normal Bullet");
            Health = Health - 10;
        }
    }
}
