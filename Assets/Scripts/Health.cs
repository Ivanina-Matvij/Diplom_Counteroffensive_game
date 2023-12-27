using System;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int maxHealth = 100; // Максимальне здоров'я
    private int currentHealth;   // Поточне здоров'я

    void Start()
    {
        currentHealth = maxHealth; // Початкове поточне здоров'я рівне максимальному
    }

    public void TakeDamage(int damageAmount)
    {
        currentHealth -= damageAmount; // Віднімаємо здоров'я на величину ушкодження

        if (currentHealth <= 0)
        {
            Die(); // Якщо здоров'я вичерпано або менше нуля, викликаємо метод смерті
        }
    }

    void Die()
    {
        // Логіка, яку потрібно виконати під час смерті об'єкта
        Debug.Log("Об'єкт помер");

        // Знищуємо об'єкт
        Destroy(gameObject);
    }
}
