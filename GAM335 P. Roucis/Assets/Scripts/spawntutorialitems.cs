using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class spawntutorialitems : MonoBehaviour
{
    public GameObject Gun;
    public GameObject Text;
    public GameObject Enemy;
    void Start()
    {
        Gun.SetActive(false);
        Text.SetActive(false);
        Enemy.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Gun.SetActive(true);
            Text.SetActive(true);
            Enemy.SetActive(true);

        }
    }
}
