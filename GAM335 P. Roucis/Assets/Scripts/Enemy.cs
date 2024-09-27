using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private GameObject player;
    public float moveSpeed = 1f;
    int health = 5;
    // Start is called before the first frame update
    void Start()
    {
        MoveTo();
        health = 5;
    }

    // Update is called once per frame
    void Update()
    {

        if (health <= 0)
        {

            Destroy(gameObject);
        }
        if (health > 1)
        {
            transform.position = Vector3.MoveTowards(transform.position, player.transform.position, moveSpeed * Time.deltaTime);
        }

    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag("Bullet"))
        {
            health -= 1;
            Debug.Log("Ow");
        }
    }

    void MoveTo()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }
}
