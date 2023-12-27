using UnityEngine;

public class Fire : MonoBehaviour
{
    void Update()
    {
        // Перевіряємо, чи натиснута кнопка "Space"
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Створюємо луч, починаючи з позиції цього об'єкта та в напрямку вперед
            Ray ray = new Ray(transform.position, transform.forward);

            // Визначаємо дальність луча (можна регулювати за потребою)
            float rayDistance = 10f;

            // Перевіряємо чи є зіткнення луча з колайдерами
            if (Physics.Raycast(ray, out RaycastHit hit, rayDistance))
            {
                // Отримуємо групу об'єктів, яка була влучена лучем
                GameObject hitObject = hit.collider.gameObject;

                // Знищуємо цей об'єкт
                Destroy(hitObject);

                // Можна вивести інформацію про зіткнення у консоль (для налагодження)
                Debug.Log($"Зіткнення з {hitObject.name}!");
            }
        }
    }
}
