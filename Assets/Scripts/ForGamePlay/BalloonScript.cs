using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonScript : MonoBehaviour
{
    private Rigidbody2D rb2d;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        rb2d.velocity = new Vector2(0, 0.3f);
    }
    void Update()
    {
        if(gameObject.transform.position.y>=5)
        {
            Debug.Log("ISCHANCE");
            rb2d.velocity = new Vector2(0,-0.3f);
        }

        if (gameObject.transform.position.y <= 3)
        {
            rb2d.velocity = new Vector2(0, 0.3f);
        }
    }
}
