using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    /*[SerializeField]
    private Text HealthText;

    public void UpdateHealth(int health)
    {
        HealthText.text = "Health: " + health;
    }*/


    #region Editor Visisble Properties

    #endregion

    #region Unity Methods

    void Start()
    {
        SetFillAmount(1f);
    }
    void Update()
    {
       // healthbarpivot.lookat(Camera.main.transform.position);
    }
    #endregion

    public void SetFillAmount(float amount)
    {
        //healthbarimage.fillamount = amount;
    }
}
