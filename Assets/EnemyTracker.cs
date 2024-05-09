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
        // Перевірити, чи залишилися вороги
        if (enemiesRemaining == 0)
        {
            GameManager.Instance.PlayerWins();
        }
    }

    public void EnemyDestroyed()
    {
        enemiesRemaining--;
    }


}