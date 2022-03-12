using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedItemController : MonoBehaviour
{

    private float MoveSpeed = -0.03f;
    void Start()
    {
        
    }

    void FixedUpdate()
    {
        gameObject.transform.position = new Vector2(transform.position.x, transform.position.y + MoveSpeed);
    }

}
