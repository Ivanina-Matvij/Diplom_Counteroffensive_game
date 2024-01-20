// Enemy.cs
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private Transform _gunPointer;
    [SerializeField] private Transform _player;
    [SerializeField] private float _stoppingDistance;
    [SerializeField] private float _retreatDistance;
    [SerializeField] private float speed;

    public float StoppingDistance => _stoppingDistance;
    public float RetreatDistance => _retreatDistance;

    void Start()
    {
        _player = GameObject.FindWithTag("Player").transform;
    }

    void Update()
    {
        if (_player != null)
        {
            var direction = _player.position - transform.position;
            Ray ray = new Ray(_gunPointer.position, _gunPointer.forward);
            RaycastHit hitInfo;

            if (Physics.Raycast(ray, out hitInfo))
            {
                if (hitInfo.collider.gameObject.CompareTag("Player"))
                {
                    EnemyMove(direction);
                }
            }
        }
    }

    private void EnemyMove(Vector3 direction)
    {
        Vector3 normalizedDirection = new Vector3(direction.x, direction.y, 0f).normalized;
        float distanceToPlayer = direction.magnitude;

        if (distanceToPlayer > _stoppingDistance)
        {
            transform.position = Vector3.MoveTowards(transform.position, _player.position, speed * Time.deltaTime);
        }
        else if (distanceToPlayer < _retreatDistance)
        {
            transform.position = Vector3.MoveTowards(transform.position, transform.position + normalizedDirection, -speed * Time.deltaTime);
        }
    }
}
