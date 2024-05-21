using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyTracker : MonoBehaviour
{
    public static int enemiesRemaining;

    void Start()
    {
        enemiesRemaining = GameObject.FindGameObjectsWithTag("Enemy").Length;
        Debug.Log(enemiesRemaining);

    }

    void Update()
    {
        Win();
    }

    public void EnemyDestroyed()
    {
        enemiesRemaining--;
    }

    private void Win()
    {
        if (enemiesRemaining == 0)
        {
            GameManager.Instance.PlayerWins();
        }
    }


}