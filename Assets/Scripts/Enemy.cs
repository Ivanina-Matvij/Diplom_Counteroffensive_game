using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private Rotator rotator;
    private Transform _target;
    void Start()
    {
        _target = GameObject.FindWithTag("Player").transform;
    }
    void Update()
    {
        var direction = _target.position - transform.position;
    }
}
