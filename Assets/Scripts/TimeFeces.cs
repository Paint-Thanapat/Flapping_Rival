using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeFeces : MonoBehaviour
{
    public GameObject FecesTime;
    public GameObject Feces;

    void Start()
    {
        FecesTime.SetActive(false);
    }
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("BreadItem"))
        {
            Destroy(collision.gameObject);
            FecesTime.SetActive(true);
            Invoke("DoFeces", 3);
        }
    }

    public void DoFeces()
    {
        Instantiate(Feces, new Vector2 (gameObject.transform.position.x,gameObject.transform.position.y - 1), gameObject.transform.rotation);
        FecesTime.SetActive(false);
    }

}
