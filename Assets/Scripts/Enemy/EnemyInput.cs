using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.PackageManager;
using UnityEngine;

public class EnemyInput : MonoBehaviour
{

    RaycastHit hitInfo = new RaycastHit();

    

    private void Update()
    {
        EnemyFire enemyFire = FindAnyObjectByType<EnemyFire>();
        Transform gunPointer = enemyFire._gunPointer;
        Ray ray = new Ray(gunPointer.position, gunPointer.forward);
        Debug.DrawRay(ray.origin, ray.direction * 100f, Color.red);

        if (Physics.Raycast(ray, out hitInfo))
        {
            if (hitInfo.collider.gameObject.CompareTag("Player"))
            {
                enemyFire.FireTank();
            }
        }
    }
}
