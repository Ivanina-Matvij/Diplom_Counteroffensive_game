using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    [SerializeField] private Transform target;
    [SerializeField] private Vector3 offset;
    public float smoothTime = 03F;

    private void Start()
    {
        target = GameObject.FindWithTag("Player").transform;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (target != null)
        {
            Vector3 desiredPosition = target.position + offset;
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothTime);
            transform.position = smoothedPosition;
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Exitgame();
        }

    }

    void Exitgame()
    {
        Application.Quit();
    }
}
