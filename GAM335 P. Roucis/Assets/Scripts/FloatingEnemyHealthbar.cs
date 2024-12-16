using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class FloatingEnemyHealthbar : MonoBehaviour
{
    [SerializeField] private Slider slider; //gets slider from canvas
    [SerializeField] private Transform target; //sticks on enemy transform
    [SerializeField] private Vector3 offset; //incase we want to move healthbar somewhere else around enemy

    Camera camera; //camera variable
    public void UpdateHealthBar(float currentValue, float maxValue)
    {
         slider.value = currentValue/maxValue; //"front and back" of slider
    }

    private void Start()
    {
        camera = GameObject.Find("Main Camera").GetComponent<Camera>(); //finds camera
    }
    void Update()
    {
        transform.rotation = camera.transform.rotation; //sets rotation relative to camera
        transform.position = target.position + offset;
    }
}
