using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] private Transform head;

    private Camera _camera;

    private void Start()
    {
        _camera = Camera.main;
    }

    private void Update()
    {
        PlayerRotate();
    }

    public void PlayerRotate()
    {
        Vector3 mousePosition = Input.mousePosition;

        Ray ray = Camera.main.ScreenPointToRay(mousePosition);

        Plane groundPlane = new Plane(Vector3.up, Vector3.zero);

        float rotationSpeed = 1;

        if (groundPlane.Raycast(ray, out float rayDistance))
        {
            Vector3 hitPoint = ray.GetPoint(rayDistance);

            Vector3 directionToHitPoint = hitPoint - transform.position;

            float angle = Mathf.Atan2(directionToHitPoint.x, directionToHitPoint.z) * Mathf.Rad2Deg;

            Quaternion rotation = Quaternion.Euler(0, angle, 0);

            transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * rotationSpeed);

            if (head != null)
            {
                head.rotation = Quaternion.Slerp(head.rotation, rotation, Time.deltaTime * rotationSpeed);
            }
        }
    }

}
