using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BeatScrollerBattleSystem : MonoBehaviour
{
    public float beatTempo;
    public bool hasStarted = false;
   
 
    // Start is called before the first frame update
    void Start()
    {
       
        beatTempo = beatTempo / 60f;
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.position -= new Vector3(beatTempo * Time.deltaTime, 0f,0f);
    }
}
