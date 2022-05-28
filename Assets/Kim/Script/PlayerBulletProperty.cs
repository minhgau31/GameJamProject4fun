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

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == " Enemy ")
        {
            Debug.Log(collision.tag == " Enemy ");
            Destroy(gameObject);
        }

    }

    private void FixedUpdate()
    {
        Destroy(gameObject, 3.0f);
    }


}
