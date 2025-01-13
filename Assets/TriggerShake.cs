using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerShake : MonoBehaviour
{
   private CameraShake cameraShake;

    void Start()
    {
        // Get the CameraShake component from the main camera
        cameraShake = Camera.main.GetComponent<CameraShake>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the collided object has the tag "ShakeTrigger"
        if (collision.gameObject.CompareTag("ShakeTrigger"))
        {
            StartCoroutine(cameraShake.Shake(0.5f, 0.2f)); // Shake for 0.5 seconds with 0.2 magnitude
        }
    }
}
