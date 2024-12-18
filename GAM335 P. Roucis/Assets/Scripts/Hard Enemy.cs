using System.Collections;
using System.Collections.Generic;
using TMPro;
using unity;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HardEnemy : MonoBehaviour
{
    private GameObject player;
    public float moveSpeed = 1f;
    public int health;
    public int score;
    public int maxHealth = 10;

    [SerializeField] FloatingEnemyHealthbar healthbar;

    // Start is called before the first frame update

    private void Awake()
    {
        healthbar = GetComponentInChildren<FloatingEnemyHealthbar>();
    }
    void Start()
    {
        health = 10;

        healthbar.UpdateHealthBar(health, maxHealth);

    }

    // Update is called once per frame
    void Update()
    {
        Health();
        MoveTo();

    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag("Hard Bullet"))
        {
            health--;
            healthbar.UpdateHealthBar(health, maxHealth);
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

        }
        if (health > 1)
        {
            this.gameObject.SetActive(true);

        }
    }
}
