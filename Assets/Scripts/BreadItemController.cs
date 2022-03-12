using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreadItemController : MonoBehaviour
{
    private float MoveSpeed = 0.015f;
    void Start()
    {
        
    }

    void Update()
    {
        gameObject.transform.position = new Vector2(transform.position.x, transform.position.y + MoveSpeed);
    }
}
