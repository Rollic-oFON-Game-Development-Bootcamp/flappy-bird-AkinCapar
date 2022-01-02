using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    [SerializeField] GameObject startCanvas;
    [SerializeField] GameObject gameOverCanvas;
    //[SerializeField] GameObject gameplayCanvas;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }

        Time.timeScale = 0f;
    }

    private void Start()
    {
        startCanvas.SetActive(true);
        //gameplayCanvas.SetActive(false);
        gameOverCanvas.SetActive(false);
    }

    public void PlayGame()
    {
        Time.timeScale = 1f;
        startCanvas.SetActive(false);
        //gameplayCanvas.SetActive(true);
    }

    public void GameOver()
    {
        Time.timeScale = 0f;
        //gameplayCanvas.SetActive(false);
        gameOverCanvas.SetActive(true);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(0);
    }

}
