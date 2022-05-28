using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
    public Transform checkpoint1;
    public Transform checkpoint2;
    int Health = 100;
    public GameManager gameManager;
    public bool check1 = true;
    public bool check2 = false;

    
    // Update is called once per frame
    void Update()
    {
        playerMove();
    }

    void playerMove()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (check1 == true && gameManager.perfectHit == true)
            {
                transform.position = Vector3.MoveTowards(this.transform.position, checkpoint1.position, 1.0f);
            }
            else if (check1 == true && gameManager.goodHit == true)
            {
                transform.position = Vector3.MoveTowards(this.transform.position, checkpoint1.position, 0.5f);
            }
            else if (check1 == true && gameManager.normalHit == true)
            {
                transform.position = Vector3.MoveTowards(this.transform.position, checkpoint1.position, 0.2f);
            }
        }
    }

    private void OnTriggerEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "smallBullet")
        {
            Health = Health - 5;
            Debug.Log(Health);
        }

        else if (collision.gameObject.tag == "mediumBullet")
        {
            Health = Health - 10;
        }

        else
        {
            Health = Health - 15;
        }


        
    }
}
