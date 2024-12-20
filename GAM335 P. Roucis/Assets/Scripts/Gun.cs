using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gun : MonoBehaviour
{
    public Transform BulletSpawnPoint;
    public GameObject BulletPrefab;
    public float bulletSpeed;
    public AudioSource GameManager;
    public AudioClip Bullet;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            GameManager.clip = Bullet;
            GameManager.Play();
            var bullet = Instantiate(BulletPrefab, BulletSpawnPoint.position, BulletSpawnPoint.rotation);
            bullet.GetComponent<Rigidbody>().velocity = BulletSpawnPoint.forward * bulletSpeed;
        }

    }
}
