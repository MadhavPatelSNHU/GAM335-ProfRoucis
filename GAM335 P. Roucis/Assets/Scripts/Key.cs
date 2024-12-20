using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Key : MonoBehaviour
{
    public UnityEvent Pickup; // I GUESS ILL TRY TO USE AN EVENT IN A CLASS THATS ABOUT EVENTS
    public AudioSource GameManager;
    public AudioClip key;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            GameManager.clip = key;
            GameManager.Play();
            Pickup.Invoke();
        }
    }
}
