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
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (check1 == true)
            {
                Debug.Log("Move");
                transform.position = Vector3.MoveTowards(this.transform.position, checkpoint1.position, 0.05f);
                transform.right = checkpoint1.position - transform.position;
                if (transform.position==checkpoint1.position)
                {
                    check2 = true;
                    check1 = false;
                }
            }

            if (check2 == true)
            {
                transform.position = Vector3.MoveTowards(this.transform.position, checkpoint2.position, 0.05f);
            }

        }
    }

    void Travel()
    {
        //if (gameManager.perfectHit == true)
        //{
        //    Vector2 destination = Vector2.Lerp(this.transform.position, checkpoint1.position,);
        //}

        //if (gameManager.goodHit == true)
        //{
        //    Vector2 destination = Vector3.MoveTowards(this.transform.position, checkpoint1.position, );
        //}
       
    }


    private void OnColliderEnter2D(Collider2D collision)
    {
        if (collision.tag == "smallBullet")
        {
            Health = Health - 5;
            Debug.Log(Health);
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
