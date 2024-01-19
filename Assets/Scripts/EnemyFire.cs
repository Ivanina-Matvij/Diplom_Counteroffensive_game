using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFire : MonoBehaviour
{
    [SerializeField] private GameObject _bulletPrafab;
    [SerializeField] private Transform _gunPointer;
    [SerializeField] private float bulletSpeed;
    [SerializeField] private float Delay;
    private Coroutine _fireRoutine;

    public void FireTank()
    {
        if (_fireRoutine != null)
            return;

        Ray ray = new Ray(_gunPointer.position, _gunPointer.forward);
        RaycastHit hitInfo;

        if (Physics.Raycast(ray, out hitInfo))
        {
            if (hitInfo.collider.gameObject.CompareTag("Player"))
            {
                var bullet = Instantiate(_bulletPrafab, _gunPointer.position, Quaternion.identity);
                var bulletRigidbody = bullet.GetComponent<Rigidbody>();
                bulletRigidbody.velocity = _gunPointer.forward * bulletSpeed;
                _fireRoutine = StartCoroutine(FireDelay());
            }
        }
    }

    private IEnumerator FireDelay()
    {
        yield return new WaitForSeconds(Delay);
        _fireRoutine = null;
    }
}
