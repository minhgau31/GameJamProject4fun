using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletProperty : MonoBehaviour
{

    public float speed;
    public Rigidbody2D rb;
    Vector2 bulletDirection;
    PlayerBehavior target;

    // Start is called before the first frame update
    void Start()
    {
        rb.GetComponent<Rigidbody2D>();
        target = GameObject.FindObjectOfType<PlayerBehavior>();
        bulletDirection = (target.transform.position - transform.position).normalized * speed;
        rb.velocity = new Vector2(bulletDirection.x, bulletDirection.y);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log(" Hit ");
            Destroy(gameObject);
        }
    }


    // Update is called once per frame
    void FixedUpdate()
    {
        Destroy(gameObject, 3.0f);
    }
}
