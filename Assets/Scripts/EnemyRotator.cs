using UnityEngine;


public class EnemyRotator: MonoBehaviour
{
    [SerializeField] private Transform player;

    private void Update()
    {
        RotateTowardsPlayer();
    }

    private void RotateTowardsPlayer()
    {
        if (player != null)
        {
            Vector3 directionToPlayer = player.position - transform.position;
            float angle = Mathf.Atan2(directionToPlayer.x, directionToPlayer.z) * Mathf.Rad2Deg;

            Quaternion rotation = Quaternion.Euler(0, angle, 0);
            transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime);
        }
    }
}
