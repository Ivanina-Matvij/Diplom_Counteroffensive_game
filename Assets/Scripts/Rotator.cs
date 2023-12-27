using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;



public class Rotator : MonoBehaviour
{

    [SerializeField] private Transform head;

    private Camera _camera;
    private void Start()
    {
        _camera= Camera.main; 
    }
    private void Update()
    {
        Vector3 mousePosition = Input.mousePosition;

        Ray ray = Camera.main.ScreenPointToRay(mousePosition);

        Plane groundPlane = new Plane(Vector3.up, Vector3.zero);

        float rotationSpeed = 1;

        //Vector2 screenMousePosition = Input.mousePosition;
        //Vector2 worldMousePosition = _camera.ScreenToWorldPoint(screenMousePosition);
        if (groundPlane.Raycast(ray, out float rayDistance))
        {
            Vector3 hitPoint = ray.GetPoint(rayDistance);

            // Отримайте напрямок до точки зіткнення
            Vector3 directionToHitPoint = hitPoint - transform.position;

            // Отримайте кут повороту
            float angle = Mathf.Atan2(directionToHitPoint.x, directionToHitPoint.z) * Mathf.Rad2Deg;

            // Створіть кватерніон повороту
            Quaternion rotation = Quaternion.Euler(0, angle, 0);

            // Використовуйте Quaternion.Slerp для плавного повороту
            transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * rotationSpeed);

            // Опціонально, можна зробити також для head, якщо потрібно
            if (head != null)
            {
                head.rotation = Quaternion.Slerp(head.rotation, rotation, Time.deltaTime * rotationSpeed);
            }
        }

    }
}
