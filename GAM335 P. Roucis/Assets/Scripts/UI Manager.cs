using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    private Text HealthText;

    public void UpdateHealth(int health)
    {
        HealthText.text = "Health: " + health;
    }
}
