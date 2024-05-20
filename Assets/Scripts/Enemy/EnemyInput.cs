using UnityEngine;

public class EnemyInput : MonoBehaviour
{
    private EnemyFire enemyFire;
    private Transform gunPointer;

    private void Start()
    {
        enemyFire = GetComponent<EnemyFire>();
        if (enemyFire != null)
        {
            gunPointer = enemyFire._gunPointer;
        }
    }

    private void Update()
    {
        if (gunPointer != null)
        {
            RaycastHit[] hits = Physics.SphereCastAll(gunPointer.position, 0.5f, gunPointer.forward, 10f);

            foreach (RaycastHit hit in hits)
            {
                if (hit.collider.gameObject.CompareTag("Player"))
                {
                    enemyFire.FireTank();
                    break;
                }
            }
        }
    }
}