using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HardBullet : MonoBehaviour
{
    public float life = 1f;


    void Start()
    {
        Destroy(gameObject, life);

    }

    void Update()
    {

    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag("Enemy"))
        {
           
            Destroy(this.gameObject);


        }
    }
}

