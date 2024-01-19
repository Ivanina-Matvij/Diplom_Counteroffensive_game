using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyInput : MonoBehaviour
{
    [SerializeField] private EnemyFire _fire;
    void Update()
    {
        _fire.FireTank();
    }

}
