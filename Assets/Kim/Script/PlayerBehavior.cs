using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
    public Transform checkpoint1;
    public Transform checkpoint2;
    int Health = 100;
    public GameManager gameManager;
    public WayPoint Destination;
    public bool ReachedDestination = false;
 

    public bool ableToShoot = false;
    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Space))
        {

            Travel();
        }
    }

    void Travel()
    {
        float dist = Vector3.Distance(transform.position, Destination.transform.position);
        if (Vector3.Distance(transform.position, Destination.transform.position) < 0.02f)
        {
            ReachedDestination = true;
            Destination = Destination.Destination;
        }
        if (ableToShoot == false)
        {
            if (gameManager.perfectHit == true)
            {
                transform.position = Vector3.MoveTowards(this.transform.position, Destination.transform.position, 0.5f);
            }

            if (gameManager.goodHit == true)
            {
                transform.position = Vector3.MoveTowards(this.transform.position, Destination.transform.position, 0.5f);
            }
        }

    }


    private void OnCollisionEnter2D(Collision2D collision)
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
        if (collision.gameObject.tag == "Enemy Check Point")
        {
            
            ableToShoot = true;
            Debug.Log("alo");
        }

    }
   


}
