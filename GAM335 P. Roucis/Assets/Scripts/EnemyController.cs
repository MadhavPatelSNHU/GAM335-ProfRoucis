using System.Collections;
using System.Collections.Generic;
using unity;
using UnityEngine;

[RequireComponent(typeof(Health), typeof(UIManager))]
public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Health health = GetComponent<Health>();

        UIManager healthbar = GetComponent<UIManager>();

        health.OnHealthChanged += (float ratio) =>
        {
            healthbar.SetFillAmount(ratio);
        };

        health.OnDied += () =>
        {
            Destroy(gameObject);
        };
    }
}
