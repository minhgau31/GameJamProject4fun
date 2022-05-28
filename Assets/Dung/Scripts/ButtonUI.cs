using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonUI : MonoBehaviour
{

    [SerializeField] private string newGameLevel = "Level1Test";
    [SerializeField] private string creditScreen = "Credits";
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void NewGameButton()
    {
        SceneManager.LoadScene(newGameLevel);
    }

    public void CreditButton()
    {
        SceneManager.LoadScene(creditScreen);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
