using System;
using UnityEngine;

public class Damage : MonoBehaviour
{
    [SerializeField] private Rigidbody projectilePrefab;
    [SerializeField] private string[] _damageTags;
    [SerializeField] private int _damage;

    public int damageAmount = 10;
    public float moveSpeed = 10f;

    void Update()
    {
            MoveObject();
        
    }
        private void OnCollisionEnter(Collision other)
    {
        if (Array.Exists(_damageTags, tag => other.gameObject.CompareTag(tag)))
        {
            Destroy(gameObject);
        }
    }

        private void MoveObject()
    {
        transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);
        SpawnProjectile();
    }

    private void SpawnProjectile()
    {
        Rigidbody projectile = Instantiate(projectilePrefab, transform.position, transform.rotation);
        projectile.AddForce(transform.forward * moveSpeed, ForceMode.Impulse);
        // Додайте код для роботи з новим об'єктом "projectile"
        Debug.Log("Spawn Projectile");
    }
}
