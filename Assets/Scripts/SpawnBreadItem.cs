using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBreadItem : MonoBehaviour
{
    public GameObject BreadItem;

    void Start()
    {
        StartCoroutine(SpawnBread());
    }

    void Update()
    {
        
    }

    public void SpawnBreadItems()
    {
        Instantiate(BreadItem, gameObject.transform.position, gameObject.transform.rotation);
    }
    IEnumerator SpawnBread()
    {
        while (true)
        {
            yield return new WaitForSeconds(3);
            SpawnBreadItems();
        }
    }
}
