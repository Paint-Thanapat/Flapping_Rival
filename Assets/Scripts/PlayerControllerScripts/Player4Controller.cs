using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player4Controller : MonoBehaviour
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

        rb2d.velocity = new Vector2(GameController.instance.P4Speed, 0);
    }

    void Update()
    {
        if (isDead == false)
        {
            if (Input.GetKeyDown(KeyCode.Keypad8) && canFlap == true)
            {
                rb2d.AddForce(new Vector2(0, upForce));
                canFlap = false;

                anim.SetTrigger("IdleR");
            }
            if (Input.GetKeyDown(KeyCode.Keypad5) && canFlap == false)
            {
                canFlap = true;

                anim.SetTrigger("FlapR");
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("CheckDead"))
        {
            gameObject.SetActive(false);
            GameController.instance.P4Dead = true;
        }

        if (other.gameObject.CompareTag("Finish"))
        {
            GameController.instance.P1Dead = true;
            GameController.instance.P2Dead = true;
            GameController.instance.P3Dead = true;
        }

        if (other.gameObject.CompareTag("SpeedItem"))
        {
            GameController.instance.SpeedBoostP4();
            Destroy(other.gameObject);
            Invoke("resetSpeedBoostP4", 3);
            rb2d.velocity = new Vector2(GameController.instance.P4Speed, 0);
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        rb2d.velocity = new Vector2(GameController.instance.P4Speed, 0);

        if (other.gameObject.CompareTag("Feces"))
        {
            Destroy(other.gameObject);
            GameController.instance.SlowSpeedP4();
            Invoke("resetSpeedBoostP4", 3);
            rb2d.velocity = new Vector2(GameController.instance.P4Speed, 0);
        }
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        rb2d.velocity = new Vector2(GameController.instance.P4Speed, 0);
    }

    public void resetSpeedBoostP4()
    {
        GameController.instance.P4Speed = 3;
        rb2d.velocity = new Vector2(GameController.instance.P4Speed, 0);
    }
}
