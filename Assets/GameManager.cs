using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    [SerializeField] private GameObject startCanvas;
    [SerializeField] private GameObject gameOverCanvas;
    [SerializeField] private GameObject gameplayCanvas;
    private int coinCounter = 0;
    [SerializeField] private TextMeshProUGUI coinCounterText;

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
        gameplayCanvas.SetActive(false);
        gameOverCanvas.SetActive(false);
        coinCounterText.text = coinCounter.ToString();
    }

    public void PlayGame()
    {
        Time.timeScale = 1f;
        startCanvas.SetActive(false);
        gameplayCanvas.SetActive(true);
    }

    public void GameOver()
    {
        Time.timeScale = 0f;
        gameOverCanvas.SetActive(true);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(0);
    }

    public void CoinCollected()
    {
        coinCounter++;
        coinCounterText.text = coinCounter.ToString();
    }
}
