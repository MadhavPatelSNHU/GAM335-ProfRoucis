using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class spawntutorialitems4 : MonoBehaviour
{
    public GameObject Heal;
    public GameObject PinkText;
    void Start()
    {
        PinkText.SetActive(false);
        Heal.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Heal.SetActive(true);
            PinkText.SetActive(true);
        }
    }
}
