using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class PlayerController : MonoBehaviour
{
	public Camera playerCamera;
	public float walkSpeed = 6f;
	
	public float lookSpeed = 2f;
	public float lookXLimit = 45f;

	Vector3 moveDirection = Vector3.zero;
	float rotationX = 0;

	public bool canMove = true;

	CharacterController characterController;


    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();
	//Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        
	Vector3 forward = transform.TransformDirection(Vector3.forward);
	Vector3 right = transform.TransformDirection(Vector3.right);

	characterController.Move(moveDirection * Time.deltaTime);
	
	if (canMove)
	{
		rotationX += -Input.GetAxis("Mouse Y") * lookSpeed;
		rotationX = Mathf.Clamp(rotationX, -lookXLimit, lookXLimit);
		playerCamera.transform.localRotation = Quaternion.Euler(rotationX, 0, 0);
		transform.rotation *= Quaternion.Euler(0, Input.GetAxis("Mouse X") * lookSpeed, 0);
	}

    }
}
