using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bullet : MonoBehaviour
{
    public float life = 2.5f;
    int Win;

    void Start()
    {
        Destroy(gameObject, life);
        Win = 0;
        

    }

    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Enemy"))
        {
            Win++;
            Destroy(this.gameObject);
            
            
        }
        if (Win > 2)
        {
            Debug.Log("win");
            SceneManager.LoadScene(2);
        }
    }
}
