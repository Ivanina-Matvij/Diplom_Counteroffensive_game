using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyInput : MonoBehaviour
{
    [SerializeField] private EnemyFire _fire;
    [SerializeField] private Enemy _enemy;

    private void Update()
    {
        if (_enemy != null && _enemy.StoppingDistance > 0f)
        {
            if (_enemy.StoppingDistance == this._enemy.StoppingDistance)
            {
                _fire.FireTank();
            }
        }
    }
}
