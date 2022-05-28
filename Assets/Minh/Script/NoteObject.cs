using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteObject : MonoBehaviour
{
    public bool canBePressed;

    public KeyCode keytoPress;

    public GameObject missEffect, hitEffect, goodEffect, perfectEffect, effectSpawner;

    
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
                if(Mathf.Abs(transform.position.y)>0.331f)
                {
                    GameManager.instance.NormalHit();
                    Instantiate(hitEffect, effectSpawner.transform.position, hitEffect.transform.rotation);

                }
                else if(Mathf.Abs(transform.position.y)>0.1f)
                {
                    GameManager.instance.GoodHit();
                    Instantiate(goodEffect, effectSpawner.transform.position, hitEffect.transform.rotation);
                }
                else
                {
                   
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
        }
        if(collision.tag=="EndGame")
        {
            canBePressed = false;
            Debug.Log("zzzz");

            GameManager.instance.NoteMiss();
            Instantiate(missEffect, effectSpawner.transform.position, hitEffect.transform.rotation);
        }

    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Activator")
        {
            
        }
    }
}
