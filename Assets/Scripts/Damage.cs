using System;
using UnityEditor.PackageManager;
using UnityEngine;

public class Damage : MonoBehaviour
{
    [SerializeField] private string[] damageTags;
    private EnemyTracker enemyTracker;

    void Start()
    {
        enemyTracker = FindObjectOfType<EnemyTracker>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        foreach (var tag in damageTags)
        {
            if (collision.gameObject.CompareTag(tag))
            {
                Destroy(collision.collider.gameObject);
                enemyTracker.EnemyDestroyed();
                Destroy(gameObject);
            }
        }

        if (collision.gameObject.CompareTag("wall"))
        {
            Destroy(gameObject);
        }
    }
}