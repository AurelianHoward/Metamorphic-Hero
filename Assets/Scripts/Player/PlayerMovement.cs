using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class PlayerMovement : MonoBehaviour
{
    CharacterController characterController;
    [SerializeField]
    Transform playerContainer, cameraContainer;

    [SerializeField] GameObject CentaurBody;

    public float speed = 10.0f;
    public float mouseSensitivity = 2f;
    public float gravity = 20.0f;
    public float lookUpClamp = -30f;
    public float lookDownClamp = 60f;

    private Vector3 moveDirection = Vector3.zero;
    float rotateX, rotateY;

    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Confined;
        //GameManager.ResetGame();

        characterController = GetComponent<CharacterController>();
    }

    void Update()
    {
        Locomotion();
        RotateAndLook();
        Metamorph();
    }

    void Locomotion()
    {
        //SoundManager.instance.PlayAtSource("Walking", gameObject);
        moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));
        moveDirection = transform.TransformDirection(moveDirection);
        moveDirection *= speed;

        characterController.height = 2f;
        characterController.center = new Vector3(0f, 1f, 0f);


        characterController.Move(moveDirection * Time.deltaTime);

    }

    void RotateAndLook()
    {
        rotateX = Input.GetAxis("Mouse X") * mouseSensitivity;
        rotateY -= Input.GetAxis("Mouse Y") * mouseSensitivity;

        rotateY = Mathf.Clamp(rotateY, lookUpClamp, lookDownClamp);

        transform.Rotate(0f, rotateX, 0f);

        //cameraContainer.transform.localRotation = Quaternion.Euler(rotateY, 0f, 0f);
    }

    void Metamorph()
    {
        if(CentaurBody == isActiveAndEnabled)
        {
            speed = 25.0f;
        }
    }


}
