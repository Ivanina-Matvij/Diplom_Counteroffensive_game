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

    public void ContinueButton()
    {
        SceneManager.LoadScene("Map");
        Time.timeScale = 1f;
    }

    public void ButtonQuit()
    {
        SceneManager.LoadScene("MainMenu");
        Time.timeScale = 1f;
    }
}