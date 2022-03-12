using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatingBackGround : MonoBehaviour
{
    private void OnTriggerExit2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("CheckBG"))
        {
            gameObject.transform.position = new Vector2(transform.position.x +46.08f, 0);
        }
    }
}

