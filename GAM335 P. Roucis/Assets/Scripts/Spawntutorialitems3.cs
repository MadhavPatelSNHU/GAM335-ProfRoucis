using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class spawntutorialitems3 : MonoBehaviour
{
    public GameObject Trophy;
    public GameObject Text;
    public GameObject UI;
    public GameObject DangerousTrophy;
    void Start()
    {
        Trophy.SetActive(false);
        Text.SetActive(false);
        UI.SetActive(false);
        DangerousTrophy.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Trophy.SetActive(true);
            Text.SetActive(true);
            UI.SetActive(true);
            DangerousTrophy.SetActive(true);

        }
    }
}
