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
        if (playerTransform != null)
        {
            Vector3 directionToPlayer = playerTransform.position - transform.position;
        }
        else
        {
            Background.SetActive(true);
        }
    }

    public void RestartButton()
    {
        SceneManager.LoadScene(2);
    }

    public void ButtonQuit()
    {
        SceneManager.LoadScene(0);
    }
}
