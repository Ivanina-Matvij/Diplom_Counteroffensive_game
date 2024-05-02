// Enemy.cs
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float speed;

    void Update()
    {
        EnemyMove();
    }

    private void EnemyMove()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.CompareTag("wall"))
        {
            transform.Rotate(Vector3.up * 90f);
        }
    }


}
