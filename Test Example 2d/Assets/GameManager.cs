using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject player;
    public Text gameOver;
    public GameObject retry;
    public GameObject quitGame;
    public void EndGame()
    {
        player.SetActive(false);
        retry.SetActive(true);
        quitGame.SetActive(true);
        gameOver.text = "GAME OVER";
    }
    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Health.health = 100;
        ScoreText.scoreValue = 0;
    }
    public void quit()
    {
        Application.Quit();
    }
}
