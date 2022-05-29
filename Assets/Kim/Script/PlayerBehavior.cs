using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class PlayerBehavior : MonoBehaviour
{
    public Transform checkpoint1;
    public Transform checkpoint2;
    int Health = 100;
    public GameManager gameManager;
    public WayPoint Destination;
    public bool ReachedDestination = false;
    public bool SpawnedEnemy = false;
    public bool ableToShoot = false;
    public TextMeshPro healthScript;
    // Update is called once per frame
    public void Start()
    {
      
    }
    void Update()
    {
        healthScript.text=Health.ToString();
        if (Input.GetKeyDown(KeyCode.Space))
        {

            Travel();
           Debug.Log(ableToShoot);
            Debug.Log(Destination.transform.position);
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
                transform.position = Vector3.MoveTowards(this.transform.position, Destination.transform.position, 2f);
            }

            if (gameManager.goodHit == true)
            {
                transform.position = Vector3.MoveTowards(this.transform.position, Destination.transform.position, 1f);
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
            SpawnedEnemy = true;
            ableToShoot = true;
            Debug.Log("canShoot");
        }
        if(collision. gameObject.tag=="Last Destination")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.gameObject.tag == "Last Destination")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

    }



}
