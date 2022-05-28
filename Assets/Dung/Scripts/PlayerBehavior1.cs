using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior1 : MonoBehaviour
{
    public Transform checkpoint1;
    int Health = 100;
    public GameManager gameManager;
    

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Move");
            transform.position = Vector3.MoveTowards(this.transform.position, checkpoint1.position, 0.05f );
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
