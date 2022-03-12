using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SixtyPerCamera : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("ทำงานนนนน");

        if(other.gameObject.CompareTag("Player"))
            {
                ScrollingCamera.instance.MoveCam += 0.5f;
                ScrollingCamera.instance.SetMovementCamera();
                Debug.Log("ติดโว้ยยยยยยยยยย");
        }
    }
}
