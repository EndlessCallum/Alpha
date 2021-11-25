using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public bool isGameActive;

    // Main Menu aka Start menu variables.
    public Button startButton;
    public Button exitButton;
    public TextMeshProUGUI titleText;

    // Restart Menu (Game Over) variables
    public Button restartButton;
    public Button homeButton;
    public TextMeshProUGUI restartText;

    // Game Finished variables
    public Button continueButton;
    public TextMeshProUGUI gameFinishedText;

    // Start is called before the first frame update
    void Start()
    {
        isGameActive = false;
        StartMenu();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartMenu()
    {
        startButton.gameObject.SetActive(true);
        exitButton.gameObject.SetActive(true);
        titleText.gameObject.SetActive(true);
    }

    public void StartGame()
    {
        isGameActive = true;
        startButton.gameObject.SetActive(false);
        exitButton.gameObject.SetActive(false);
        titleText.gameObject.SetActive(false);
    }

    public void RestartGame()
    {

    }

    public void GameOver()
    {
        isGameActive = false;
        restartButton.gameObject.SetActive(true);
        homeButton.gameObject.SetActive(true);
        restartText.gameObject.SetActive(true);
    }

    public void GameFinished()
    {
        Debug.Log("Game Finished");
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
