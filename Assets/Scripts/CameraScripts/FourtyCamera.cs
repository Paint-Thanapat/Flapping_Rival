using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FourtyCamera : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            ScrollingCamera.instance.MoveCam += 0.3f;
            ScrollingCamera.instance.SetMovementCamera();
        }
    }
}
