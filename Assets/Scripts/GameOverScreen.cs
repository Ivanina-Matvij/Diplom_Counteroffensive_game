using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverScreen : MonoBehaviour
{
    [SerializeField] GameObject Background;
    private Transform playerTransform;

    private void Start()
    {
        GameObject playerObject = GameObject.FindWithTag("Player");

        if (playerObject != null)
        {
            playerTransform = playerObject.transform;
        }
    }

    private void Update()
    {
        Player_Tracker();
    }

    private void Player_Tracker()
    {
        if (playerTransform != null)
        {
            Vector3 directionToPlayer = playerTransform.position - transform.position;
            Time.timeScale = 1f;
        }
        else
        {
            Background.SetActive(true);
            Time.timeScale = 0f;
        }
    }

    public void RestartButton1()
    {
        SceneManager.LoadScene("GamePlay1");
        Background.gameObject.SetActive(false);
    }

    public void RestartButton2()
    {
        SceneManager.LoadScene("GamePlay2");
        Background.gameObject.SetActive(false);
    }

    public void RestartButton3()
    {
        SceneManager.LoadScene("GamePlay3");
        Background.gameObject.SetActive(false);
    }

    public void ButtonQuit()
    {
        SceneManager.LoadScene(0);
        Background.gameObject.SetActive(false);
        
    }
}
