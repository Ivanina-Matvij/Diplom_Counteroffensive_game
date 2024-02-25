using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private Rigidbody _rigidbody;

    public float rotationSpeed = 50f;
    private Vector3 previousPosition;

    private void MoveObject()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Vector3 forwardDirection = transform.forward;
        Vector3 movement = forwardDirection * verticalInput * speed;

        previousPosition = transform.position;

        Vector3 localDirection = new Vector3(0, 0, verticalInput);
        Vector3 globalDirection = transform.TransformDirection(localDirection);
        Vector3 normalizeDirection = globalDirection.normalized;
        Vector3 movement_v = normalizeDirection * speed * Time.deltaTime;

        
        _rigidbody.MovePosition(transform.position + movement_v);

        if (horizontalInput != 0)
        {
            Rotate((float)Mathf.Sign(horizontalInput));
            
        }
    }
    // Update is called once per frame
    void Update()
    {
        MoveObject();
    }

    void Rotate(float direction)
    {
        float rotation = direction * rotationSpeed * Time.deltaTime;
        transform.Rotate(Vector3.up, rotation);
    }
}
