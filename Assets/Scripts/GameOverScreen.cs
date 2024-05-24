using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverScreen : MonoBehaviour
{
    [SerializeField] GameObject loseScreen;
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
        PlayerTracker();
    }

    private void PlayerTracker()
    {
        if (playerTransform != null)
        {
            Vector3 directionToPlayer = playerTransform.position - transform.position;
            Time.timeScale = 1f;
        }
        else
        {
            GameManager.Instance.playerDied = true;
            loseScreen.SetActive(true);
            Time.timeScale = 0f;
        }
    }

    public void RestartButton1()
    {
        SceneManager.LoadScene("GamePlay1");
        loseScreen.gameObject.SetActive(false);
    }

    public void RestartButton2()
    {
        SceneManager.LoadScene("GamePlay2");
        loseScreen.gameObject.SetActive(false);
    }

    public void RestartButton3()
    {
        SceneManager.LoadScene("GamePlay3");
        loseScreen.gameObject.SetActive(false);
    }

    public void ButtonQuit()
    {
        SceneManager.LoadScene(0);
        loseScreen.gameObject.SetActive(false);
    }
}