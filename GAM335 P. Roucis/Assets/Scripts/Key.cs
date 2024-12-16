using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Key : MonoBehaviour
{
    public UnityEvent Pickup; // I GUESS ILL TRY TO USE AN EVENT IN A CLASS THATS ABOUT EVENTS


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Pickup.Invoke();
        }
    }
}
