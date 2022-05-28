using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnenmySpawner : MonoBehaviour
{
    public PlayerBehavior pb;
    public bool spawnEnemy = false;
    public GameObject enemy;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (spawnEnemy == true)
        {
            Invoke("spawnEnemy", 5.0f);
            pb.check2 = true;
        }
    }

    void spawmEnemy()
    {
        
    }
}
