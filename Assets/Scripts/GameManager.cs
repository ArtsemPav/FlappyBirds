using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public LoseWindow loseWindow;
    public GameObject HitSound;
    public SoundManager soundManager;
    public static GameManager instance;
    private int IsSoundOff;
    private int IsSceneReLoad = 0;
    private void Start()
    {
        instance = this;
        loseWindow.gameObject.SetActive(false);
        Time.timeScale = 1;
        HitSound.SetActive(false);
        IsSceneReLoad = PlayerPrefs.GetInt("IsSceneReLoad");
        if (IsSceneReLoad == 0)
        {
            IsSoundOff = 0;
            PlayerPrefs.SetInt("IsSoundOff", IsSoundOff);
            AudioListener.volume = 1f;
            soundManager.BtnSoundsOff.SetActive(true);
            soundManager.BtnSoundsOn.SetActive(false);
        }
        else
        {
            IsSceneReLoad = 0;
            PlayerPrefs.SetInt("IsSceneReLoad", IsSceneReLoad);
            SoundInitiate();
        }
    }

    private void SoundInitiate()
    {
        IsSoundOff = PlayerPrefs.GetInt("IsSoundOff");
        if (IsSoundOff == 0)
        {
            AudioListener.volume = 1f;
            soundManager.BtnSoundsOff.SetActive(true);
            soundManager.BtnSoundsOn.SetActive(false);
        }
        else if (IsSoundOff == 1)
        {
            AudioListener.volume = 0f;
            soundManager.BtnSoundsOff.SetActive(false);
            soundManager.BtnSoundsOn.SetActive(true);
        }
    }

    public void RestartScene()
    {
        IsSceneReLoad = 1;
        PlayerPrefs.SetInt("IsSceneReLoad", IsSceneReLoad);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;
        HitSound.SetActive(false);
    }

    public void Lose()
    {
        loseWindow.gameObject.SetActive(true);
        loseWindow.PlayerLose();
        Time.timeScale = 0;
        HitSound.SetActive(true);
    }

    public void LoadScene(int scene)
    {
        SceneManager.LoadScene(scene);
        Time.timeScale = 1;
        HitSound.SetActive(false);
    }
}
