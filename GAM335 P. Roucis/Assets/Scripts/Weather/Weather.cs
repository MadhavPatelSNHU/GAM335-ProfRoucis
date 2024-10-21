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

    public GameObject Spawner0;
    public GameObject Spawner1;
    public GameObject Spawner2;

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

            switch (condition)
            {
                case "Clear":
                    Spawner0.SetActive(true);
                    Spawner1.SetActive(true);
                    Spawner2.SetActive(false);
                    break;
                case "Rain":
                    Spawner0.SetActive(false);
                    Spawner1.SetActive(true);
                    Spawner2.SetActive(true);
                    break;
                case "Drizzle":
                    Spawner0.SetActive(false);
                    Spawner1.SetActive(true);
                    Spawner2.SetActive(false);
                    break;
                case "Snow":
                    Spawner0.SetActive(true);
                    Spawner1.SetActive(true);
                    Spawner2.SetActive(true);
                    break;
            }
        }
    }
}