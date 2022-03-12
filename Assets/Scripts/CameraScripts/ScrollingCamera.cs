using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingCamera : MonoBehaviour
{
    public static ScrollingCamera instance;

    private Rigidbody2D rb2d;
    public float MoveCam;

    public bool Sixty = true;


    void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
        SetMovementCamera();

        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
    }


    void Start()
    {
        
    }


    void Update()
    {
        if(MoveCam >= 3.5f)
        {
            MoveCam = 3f;
        }

        if (MoveCam <= 1f)
        {
            MoveCam = 1f;
        }
    }

    public void SetMovementCamera()
    {
        rb2d.velocity = new Vector2(MoveCam, 0);
    }
}
