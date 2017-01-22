using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    public void StartGame()
    {
        Debug.Log("Start the game!");
        SceneManager.LoadScene("RoundOne");
    }

    public void QuitGame()
    {
        Debug.Log("Game should be closing now.");
        Application.Quit();
    }
}
