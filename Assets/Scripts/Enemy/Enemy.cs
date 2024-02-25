// Enemy.cs
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private Transform _gunPointer;
    [SerializeField] private Transform _player;
    [SerializeField] private float _stoppingDistance;
    [SerializeField] private float _retreatDistance;
    [SerializeField] private float speed;


    void Start()
    {
    }

    void Update()
    {

    }


}
