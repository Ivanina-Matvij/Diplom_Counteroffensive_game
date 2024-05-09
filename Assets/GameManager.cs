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
        }
    }

    public void ContinueButton()
    {
        SceneManager.LoadScene(1);
    }

    public void ButtonQuit()
    {
        SceneManager.LoadScene(0);
    }

}