using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingObject : MonoBehaviour
{
    public static ScrollingObject instance;

    private Rigidbody2D rb2d;
    public float MoveSpeed;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }

        rb2d = GetComponent<Rigidbody2D>();
        rb2d.velocity = new Vector2(MoveSpeed, 0);
    }

    void Start()
    {
        
    }

    
    void Update()
    {
        /*//rb2d.velocity = new Vector2(MoveSpeed, 0);
        if (checkBlock)
        {
            rb2d.velocity = new Vector2(MoveSpeed, 0);
        }*/


    }

   private void OnCollisionEnter2D(Collision2D other)
    {
        rb2d.velocity = new Vector2(MoveSpeed, 0);
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        rb2d.velocity = new Vector2(MoveSpeed, 0);
    }


}
