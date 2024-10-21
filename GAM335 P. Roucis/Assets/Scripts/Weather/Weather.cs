using System;
using System.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Networking;

public class Weather : MonoBehaviour
{
    [Serializable]
    public class Response
    {
        [Serializable]
        public class Weather
        {
            public string main;
        }

        public Weather[] weather;
    }

    [SerializeField] string APIKey;

    public GameObject enemy0;
    public GameObject enemy1;
    public GameObject enemy2;
    public GameObject Player;



    public Color clearColor;
    public Color RainColor;



    void Start()
    {
        StartCoroutine(GetWeather());
    }
    IEnumerator GetWeather()
    {
        using (UnityWebRequest webRequest = UnityWebRequest.Get("https://api.openweathermap.org/data/2.5/weather?q=hooksett,nh,usa&APPID=" + APIKey))
        {

            yield return webRequest.SendWebRequest();
            switch (webRequest.result)
            {
                case UnityWebRequest.Result.Success:
                    break;
            }
            Debug.Log(webRequest.error);
            Response resp = JsonUtility.FromJson<Response>(webRequest.downloadHandler.text);
            Debug.Log(resp.weather[0].main);
            string condition = resp.weather[0].main;

            condition = "Drizzle";

            switch (condition)
            {
                case "Clear":
                    Destroy(enemy0);
                    break;
                case "Rain":
                    Destroy(enemy1);
                    break;
                case "Drizzle":
                    GameObject.FindGameObjectWithTag("Enemy");
                    
                    break;
                case "Snow":
                    gameObject.GetComponent<Renderer>().material.color = Color.green;
                    break;
            }
        }
    }
}