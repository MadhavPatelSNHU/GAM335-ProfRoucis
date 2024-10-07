using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;


public class Movement : MonoBehaviour
{
    PlayerInput playerInput;
    InputAction moveAction;
    InputAction jumpAction;
    public Vector2 cam;
    public float speed = 10;
    public float jumpPower = 10;
    public float sensitivity;
    float xRotation;
    float yRotation;
    HashSet<int> points = new HashSet<int>();
    public int life;
    Dictionary<string, int> trophys = new Dictionary<string, int>();

    public enum AmmoType
    {
        Shotgun,
        Pistol,
        Explosive,
        LargeMachineGun,
    }

    // Start is called before the first frame update
    void Start()
    {
        playerInput = GetComponent<PlayerInput>();
        moveAction = playerInput.actions.FindAction("Move");
        jumpAction = playerInput.actions.FindAction("Jump");

        life = 5;
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
        /*CameraMove();*/
        points.Clear();
    }

    void MovePlayer()
    {
        Vector2 direction = moveAction.ReadValue<Vector2>();
        transform.position += new Vector3(direction.x, 0, direction.y) * speed * Time.deltaTime;

        Vector3 jump = jumpAction.ReadValue<Vector3>();
        transform.position += new Vector3(0, jump.z, 0) * jumpPower * Time.deltaTime;

    }

    void CameraMove()
    {
        xRotation -= Input.GetAxisRaw("Mouse Y") * Time.deltaTime * sensitivity;
        yRotation += Input.GetAxisRaw("Mouse X") * Time.deltaTime * sensitivity;

        xRotation = Mathf.Clamp(xRotation, -90f, 90f); // to stop the player from looking above/below

        transform.localEulerAngles = new Vector3(xRotation, yRotation, 0);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            life--;
        }
        if(life <= 0)
        {
            SceneManager.LoadScene(3);
        }

        if (collision.gameObject.CompareTag("Trophy1"))
        {
            points.Add(1);
            if (points.Contains(1))
            {
                SceneManager.LoadScene(3);
            }
        }
        if (collision.gameObject.CompareTag("Trophy2"))
        {
            points.Add(2);
            if (points.Contains(2))
            {
                SceneManager.LoadScene(2);
            }
        }
        if (collision.gameObject.CompareTag("Safe Trophy"))
        {
            trophys.Add("Trophy, 100 points", 100);
        }

        if (trophys.ContainsKey("Trophy, 100 points"))
        {
            int value = trophys["Trophy, 100 points"];
            Debug.Log("Safe Trophy! " + value + " Points");
        }
        else
        {
            Debug.Log("safe trophy not found");
        }
       
    }
}

