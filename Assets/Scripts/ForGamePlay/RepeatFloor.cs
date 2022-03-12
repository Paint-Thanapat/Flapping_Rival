using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatFloor : MonoBehaviour
{
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("CheckFloor"))
        {
            gameObject.transform.position = new Vector2(transform.position.x + 49.68f, -5.7f);
        }
    }
}
