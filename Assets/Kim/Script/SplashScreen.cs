using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashScreen : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        SplashScreen();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator SplashScreen()
    {

       yield return new WaitForSeconds (9);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }
}
