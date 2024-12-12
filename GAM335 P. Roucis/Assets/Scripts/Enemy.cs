using System.Collections;
using System.Collections.Generic;
using TMPro;
using unity;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    private GameObject player;
    public float moveSpeed = 1f;
    public int health;
    public int score;
    private UIManager uiManager;



    // Start is called before the first frame update
    void Start()
    {
        health = 5;
        uiManager = GameObject.Find("Canvas").GetComponent<UIManager>();
    }

    // Update is called once per frame
    void Update()
    {
        Health();
        MoveTo();

    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag("Bullet"))
        {
            health--;
            /*Debug.Log("Ow");*/
        }
    }

    void MoveTo()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        transform.position = Vector3.MoveTowards(transform.position, player.transform.position, moveSpeed * Time.deltaTime);
    }

    void Health()
    {
        if (health <= 0)
        {
            this.gameObject.SetActive(false);
            score++;
            uiManager.UpdateScore(score);

        }
        if (health > 1)
        {
            this.gameObject.SetActive(true);
            
        }
    }
}
