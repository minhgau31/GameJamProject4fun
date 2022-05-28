using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint1 : MonoBehaviour
{
    public EnenmySpawner es;
    public PlayerBehavior pb;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        {
            if (other.tag == "Player")
            {
                Debug.Log("Spawn Enemy");
               
                es.spawnEnemy = true;
            }
        }
    }
}
