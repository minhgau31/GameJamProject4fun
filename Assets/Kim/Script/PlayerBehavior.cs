using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{

    int Health = 100;

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "smallBullet")
        {
            Health = Health - 5;
        }

        else if (collision.tag == "mediumBullet")
        {
            Health = Health - 10;
        }

        else
        {
            Health = Health - 15;
        }
    }
}
