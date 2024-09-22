using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class Movement : MonoBehaviour
{
    PlayerInput playerInput;
    InputAction moveAction;
    InputAction jumpAction;
    public Vector2 cam;
    [SerializeField] float speed = 10;
    [SerializeField] float jumpPower = 10;
    [SerializeField] float sensitivity;
    float xRotation;
    float yRotation;

    // Start is called before the first frame update
    void Start()
    {
        playerInput = GetComponent<PlayerInput>();
        moveAction = playerInput.actions.FindAction("Move");
        jumpAction = playerInput.actions.FindAction("Jump");
        Cursor.lockState = CursorLockMode.Locked;

    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
        CameraMove();
    }

    void MovePlayer()
    {
        Vector2 direction = moveAction.ReadValue<Vector2>();
        transform.position += new Vector3(direction.x, direction.y) * speed * Time.deltaTime;

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
}

