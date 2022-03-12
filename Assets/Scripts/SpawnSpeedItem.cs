using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSpeedItem : MonoBehaviour
{
    public GameObject BoostSpeedItem;


    void Start()
    {
        StartCoroutine(SpawnSpeedBoost());
    }

    void Update()
    {
        
    }

    public void SpawnSpdItem()
    {
        Instantiate(BoostSpeedItem,gameObject.transform.position,gameObject.transform.rotation);
    }

    IEnumerator SpawnSpeedBoost()
    {
        while (true)
        {
            yield return new WaitForSeconds(3);
            SpawnSpdItem();
        }
    }
}
