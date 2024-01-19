using UnityEngine;


public class EnemyRotator: MonoBehaviour
{
    [SerializeField] private Transform player;
    private Transform _target;

    private void Start()
    {
        if (player != null)
            _target = GameObject.FindWithTag("Player").transform;
    }

    private void Update()
    {
        RotateTowardsPlayer();
    }

    private void RotateTowardsPlayer()
    {
        if (_target != null)
        {
            Vector3 directionToPlayer = _target.position - transform.position;
            float angle = Mathf.Atan2(directionToPlayer.x, directionToPlayer.z) * Mathf.Rad2Deg;
            Quaternion rotation = Quaternion.Euler(0, angle, 0);
            transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime);
        }

        
    }
}
