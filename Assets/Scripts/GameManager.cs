using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    [SerializeField] private GameObject winScreen;


    void Awake()
    {
        Instance = this;
    }

    public void PlayerWins()
    {
        winScreen.gameObject.SetActive(true);
        Time.timeScale = 0f;
    }
    void UnlockNewLevel()
    {
        if (SceneManager.GetActiveScene().buildIndex >= PlayerPrefs.GetInt("ReachedIndex"))
        {
            PlayerPrefs.SetInt("ReachedIndex", SceneManager.GetActiveScene().buildIndex + 1);
            PlayerPrefs.SetInt("UnlockedLevel", PlayerPrefs.GetInt("UnlockedLevel", 1) + 1);
            PlayerPrefs.Save();
        }
    }

    public void ContinueButton()
    {
        UnlockNewLevel();
        SceneManager.LoadScene("Map");
        Time.timeScale = 1f;
    }

    public void ButtonQuit()
    {
        SceneManager.LoadScene("MainMenu");
        Time.timeScale = 1f;
    }
}