using UnityEngine;



public class EnemyRotator: MonoBehaviour
{
    [SerializeField] private EnemyInput _enemyInput;
    [SerializeField] private EnemyFire _fire;
    [SerializeField] private Transform player;
    [SerializeField] private float rotationSpeed;
    private Transform _target;
    

    private void Start()
    {
        if (player != null)
            _target = GameObject.FindWithTag("Player").transform;
    }

    private void Update()
    {
        if (_target != null)
        {
            RotateTowardsPlayer();
        }
    }

    private void RotateTowardsPlayer()
    {
        if (_target != null)
        {
            Vector3 directionToPlayer = _target.position - transform.position;

            Quaternion targetRotation = Quaternion.LookRotation(directionToPlayer);

            transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
        }
    }


}
