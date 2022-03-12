using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatCloud : MonoBehaviour
{
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("CheckCloud"))
        {
            gameObject.transform.position = new Vector2(transform.position.x + 50, 5);
        }
    }
}
