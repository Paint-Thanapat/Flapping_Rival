using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlippersRotate : MonoBehaviour
{

    
    void Start()
    {
        
    }

    void FixedUpdate()
    {
        transform.Rotate(0, 0, 0.5f);
    }
}
