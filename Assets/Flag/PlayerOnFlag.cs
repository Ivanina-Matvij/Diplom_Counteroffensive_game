using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerOnFlag : MonoBehaviour
{
    private bool isOnCircle = false;
    private float timer = 0f;

    private void Update()
    {
        if (isOnCircle)
        {
            timer += Time.deltaTime;

            if (timer >= 5f)
            {
                ChangeCircleColor(Color.green);
            }
        }
    }

    private void ChangeCircleColor(Color color)
    {
        Renderer renderer = GetComponent<Renderer>();
        renderer.material.color = color;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isOnCircle = true;
        }
    }

    // Викликається, коли гравець покидає коло
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isOnCircle = false;
            timer = 0f;
        }
    }

}
