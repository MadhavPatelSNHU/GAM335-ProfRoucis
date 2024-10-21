using System;
using System.Collections;
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
    void Start()
    {
        StartCoroutine(GetWeather());
    }
    IEnumerator GetWeather()
    {
        using (UnityWebRequest webRequest = UnityWebRequest.Get("https://api.openweathermap.org/data/2.5/weather?q=hooksett,nh,usa&APPID=" + APIKey))
        {

            yield return webRequest.SendWebRequest();
            Response resp = JsonUtility.FromJson<Response>(webRequest.downloadHandler.text);
            Debug.Log(resp.weather[0].main);
            // Your game code to handle the contents of "main" here
        }
    }
}