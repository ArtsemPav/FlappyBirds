using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public LoseWindow loseWindow;
    public static GameManager instance;
    private void Start()
    {
        instance = this;
        loseWindow.gameObject.SetActive(false);
        Time.timeScale = 1;
    }
    public void RestartScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;
    }

    public void Lose()
    {
        loseWindow.gameObject.SetActive(true);
        loseWindow.PlayerLose();
        Time.timeScale = 0;
    }

    public void LoadScene(int scene)
    {
        SceneManager.LoadScene(scene);
        Time.timeScale = 1;
    }
}
