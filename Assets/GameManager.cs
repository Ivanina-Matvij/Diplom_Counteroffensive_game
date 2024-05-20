using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    private bool playerWon = false;
    [SerializeField] private GameObject Background_w;

    void Awake()
    {
        Instance = this;
    }

    public void PlayerWins()
    {
        if (!playerWon)
        {
            playerWon = true;
            Background_w.gameObject.SetActive(true);
            Time.timeScale = 0f;
        }
    }

    public void ContinueButton()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1f;
    }

    public void ButtonQuit()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1f;
    }

}