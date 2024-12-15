using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class starburst : MonoBehaviour
{

    public void Start()
    {
        
    }

    // Update is called once per frame
    public void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
}
