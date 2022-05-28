using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteObjectBattleSystem : MonoBehaviour
{
    public bool canBePressed;

    public KeyCode keytoPress;

    public GameObject missEffect, hitEffect, goodEffect, perfectEffect, effectSpawner;

    public BulletSpawn bulletSpawn;
    
    // Start is called before the first frame update
    void Start()
    {
        effectSpawner = GameObject.Find("effectSpawner");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(keytoPress))
        {
            if(canBePressed)
            {
                gameObject.SetActive(false);

                //GameManager.instance.NoteHit();
                if(Mathf.Abs(this.transform.position.x) < 1.8f|| (Mathf.Abs(this.transform.position.x) > 2.35f))
                {
                    Debug.Log(Mathf.Abs(transform.position.x));
                    GameManager.instance.NormalHit();
                    Instantiate(hitEffect, effectSpawner.transform.position, hitEffect.transform.rotation);

                }
                else if (Mathf.Abs(this.transform.position.x) < 1.95f || (Mathf.Abs(this.transform.position.x) > 2.18f))
                {
                    Debug.Log(Mathf.Abs(transform.position.x));
                    GameManager.instance.GoodHit();
                    Instantiate(goodEffect, effectSpawner.transform.position, hitEffect.transform.rotation);
                }
                else 
                {
                    Debug.Log(Mathf.Abs(transform.position.x));
                    GameManager.instance.PerfectHit();
                    Instantiate(perfectEffect, effectSpawner.transform.position, hitEffect.transform.rotation);
                }
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag=="Activator")
        {
            canBePressed = true;
            bulletSpawn.canShoot = true;
            Debug.Log(bulletSpawn.canShoot);
            return;
        }
        if(collision.tag=="EndGame")
        {
            canBePressed = false;
            Debug.Log("zzzz");

            GameManager.instance.NoteMiss();
            Instantiate(missEffect, effectSpawner.transform.position, hitEffect.transform.rotation);
            gameObject.SetActive(false);
        }

    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Activator")
        {
            
        }
    }
}
