using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class spawntutorialitems2 : MonoBehaviour
{
    public GameObject Door;
    public GameObject Text;
    public GameObject Key;
    void Start()
    {
        Door.SetActive(false);
        Text.SetActive(false);
        Key.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Door.SetActive(true);
            Text.SetActive(true);
            Key.SetActive(true);

        }
    }
}
