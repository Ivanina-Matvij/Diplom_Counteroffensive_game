using UnityEngine;
using UnityEngine.UI;

public class PlayerOnFlag : MonoBehaviour
{
    private bool isOnFlag = false;
    private float timer = 0f;
    private const float targetTime = 5f; 

    private void Update()
    {
        if (isOnFlag)
        {
            timer += Time.deltaTime;
            if (timer >= targetTime)
            {
                GameManager.Instance.PlayerWins();
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isOnFlag = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isOnFlag = false;
            timer = 0f;
        }
    }
}