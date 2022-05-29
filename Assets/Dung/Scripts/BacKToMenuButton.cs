using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BacKToMenuButton : MonoBehaviour
{
    [SerializeField] private string back2MenuButton;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void backToMenuButton()
    {
        SceneManager.LoadScene(back2MenuButton);
    }
}
