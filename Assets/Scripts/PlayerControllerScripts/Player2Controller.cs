using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Controller : MonoBehaviour
{
    public float upForce = 200f;
    private bool isDead = false;
    private bool canFlap = true;

    private Rigidbody2D rb2d;
    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();

        rb2d.velocity = new Vector2(GameController.instance.P2Speed, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (isDead == false)
        {
            if (Input.GetKeyDown(KeyCode.UpArrow) && canFlap == true)
            {
                rb2d.AddForce(new Vector2(0, upForce));
                canFlap = false;

                anim.SetTrigger("IdleB");
            }
            if (Input.GetKeyDown(KeyCode.DownArrow) && canFlap == false)
            {
                canFlap = true;

                anim.SetTrigger("FlapB");
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("CheckDead"))
        {
            gameObject.SetActive(false);
            GameController.instance.P2Dead = true;
        }

        if (other.gameObject.CompareTag("Finish"))
        {
            GameController.instance.P1Dead = true;
            GameController.instance.P3Dead = true;
            GameController.instance.P4Dead = true;
        }

        if (other.gameObject.CompareTag("SpeedItem"))
        {
            GameController.instance.SpeedBoostP2();
            Destroy(other.gameObject);
            Invoke("resetSpeedBoostP2", 3);
        }

        if (other.gameObject.CompareTag("SpeedItem"))
        {
            GameController.instance.SpeedBoostP2();
            Destroy(other.gameObject);
            Invoke("resetSpeedBoostP2", 3);
            rb2d.velocity = new Vector2(GameController.instance.P2Speed, 0);
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        rb2d.velocity = new Vector2(GameController.instance.P2Speed, 0);

        if (other.gameObject.CompareTag("Feces"))
        {
            Destroy(other.gameObject);
            GameController.instance.SlowSpeedP2();
            Invoke("resetSpeedBoostP2", 3);
            rb2d.velocity = new Vector2(GameController.instance.P2Speed, 0);
        }
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        rb2d.velocity = new Vector2(GameController.instance.P2Speed, 0);
    }

    public void resetSpeedBoostP2()
    {
        GameController.instance.P2Speed = 3;
        rb2d.velocity = new Vector2(GameController.instance.P2Speed, 0);
    }
}
