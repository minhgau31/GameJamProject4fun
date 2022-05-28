using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBulletProperty : MonoBehaviour
{

    public float speed;
    public Rigidbody2D rb;
    EnemyBehavior target;
    Vector2 bulletDirection;

    // Start is called before the first frame update
    void Start()
    {
        rb.GetComponent<Rigidbody2D>();
        target = GameObject.FindObjectOfType<EnemyBehavior>();
        bulletDirection = (target.transform.position - transform.position).normalized * speed;
        rb.velocity = new Vector2(bulletDirection.x, bulletDirection.y);
    }

   

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Debug.Log(collision.gameObject.tag == "Enemy");
            Destroy(gameObject);

        }

    }

    private void FixedUpdate()
    {
        Destroy(gameObject, 3.0f);
    }


}
