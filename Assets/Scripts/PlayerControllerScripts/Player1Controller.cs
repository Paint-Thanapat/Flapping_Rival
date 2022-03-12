using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Controller : MonoBehaviour
{
    public float upForce = 200f;
    private bool isDead = false;
    private bool canFlap = true;

    private Rigidbody2D rb2d;
    private Animator anim;


    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();

        rb2d.velocity = new Vector2(GameController.instance.P1Speed, 0);
    }

    void Update()
    {
        if(isDead == false)
        {
            if (Input.GetKeyDown(KeyCode.W) && canFlap == true)
            {
                rb2d.AddForce(new Vector2(0, upForce));
                canFlap = false;

                anim.SetTrigger("IdleO");
            }
            if (Input.GetKeyDown(KeyCode.S) && canFlap == false)
            {
                canFlap = true;

                anim.SetTrigger("FlapO");
            }
        }

        
            
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("CheckDead"))
        {
            gameObject.SetActive(false);
            GameController.instance.P1Dead = true;
        }

        if(other.gameObject.CompareTag("Finish"))
        {
            GameController.instance.P2Dead = true;
            GameController.instance.P3Dead = true;
            GameController.instance.P4Dead = true;
        }

        if (other.gameObject.CompareTag("SpeedItem"))
        {
            GameController.instance.SpeedBoostP1();
            Destroy(other.gameObject);
            Invoke("resetSpeedBoostP1", 3);
            rb2d.velocity = new Vector2(GameController.instance.P1Speed, 0);
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        rb2d.velocity = new Vector2(GameController.instance.P1Speed, 0);

        if (other.gameObject.CompareTag("Feces"))
        {
            Destroy(other.gameObject);
            GameController.instance.SlowSpeedP1();
            Invoke("resetSpeedBoostP1", 3);
            rb2d.velocity = new Vector2(GameController.instance.P1Speed, 0);
        }
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        rb2d.velocity = new Vector2(GameController.instance.P1Speed, 0);
    }

    public void resetSpeedBoostP1()
    {
        GameController.instance.P1Speed = 3;
        rb2d.velocity = new Vector2(GameController.instance.P1Speed, 0);
    }
}
