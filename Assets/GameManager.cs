using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject gameOverText;
    public GameObject restartButton;

    private void Start()
    {
        gameOverText.SetActive(false);
        restartButton.SetActive(false);
    }

    public void GameOver()
    {
        print("Game Over");
        Time.timeScale =0f;
        gameOverText.SetActive(true);
        restartButton.SetActive(true);
    }

    public void RestartGame()
    {
        print("Game Resarted");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1f;
    }
}
