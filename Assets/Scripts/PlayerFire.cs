using System;
using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerFire : MonoBehaviour
{
    [SerializeField] private GameObject _bulletPrafab;
    [SerializeField] private Transform _gunPointer;
    [SerializeField] private float  bulletSpeed;
    [SerializeField] private float Delay;
    private Coroutine _fireRoutine;

    public void FireTank()
    {
        if (_fireRoutine != null)
            return;

        var bullet = Instantiate(_bulletPrafab, _gunPointer.position, Quaternion.identity);
        var bulletRigidbody = bullet.GetComponent<Rigidbody>();
        bulletRigidbody.velocity = _gunPointer.forward * bulletSpeed;
        _fireRoutine = StartCoroutine(FireDelay());
    }

    private IEnumerator FireDelay()
    {
        yield return new WaitForSeconds(Delay);
        _fireRoutine = null;
    }
}
