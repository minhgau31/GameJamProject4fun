using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallEnemy : MonoBehaviour
{

    public int Health = 35;

    void Update()
    {
        if (Health <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Perfect Bullet")
        {
            Debug.Log("Hit by Perfect Bullet");
            Health = Health - 35;
        }

        else if (collision.gameObject.tag == "Good Bullet")
        {
            Debug.Log("Hit by Good Bullet");
            Health = Health - 20;
        }

        else if (collision.gameObject.tag == "Normal Bullet")
        {
            Debug.Log("Hit by Normal Bullet");
            Health = Health - 10;
        }
    }
}
