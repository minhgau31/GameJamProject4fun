using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBulletProperty : MonoBehaviour
{

    public float speed;
    public Rigidbody2D rb;
    

    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.up * speed;
    }

   

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {

            Debug.Log(collision.gameObject.tag == "Enemy");
            Debug.Log("Hit Enemy");
            Destroy(gameObject);

        }

    }

    private void FixedUpdate()
    {
        Destroy(gameObject, 3.0f);
    }


}
