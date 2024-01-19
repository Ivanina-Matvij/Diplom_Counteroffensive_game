using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    [SerializeField] private PlayerFire _fire;
    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            _fire.FireTank();
        }
    }
}
