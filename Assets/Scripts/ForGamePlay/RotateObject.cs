using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    void FixedUpdate()
    {
        transform.Rotate(0, 0, 3);
    }
}
