using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    //Declaring PlayerMover variables
    private CharacterController characterController;
    private Vector3 moveDirection = Vector3.zero;

    public float speed = 6f;
    public float jumpSpeed = 8f;
    public float gravity = 20f;

    // Start is called before the first frame update
    void Start()
    {
        //Declaring the character controller
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (characterController.isGrounded)
        {
            //Getting input on 
            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));

            moveDirection *= speed;

            if (Input.GetKey(KeyCode.Space))
            {
                moveDirection.y = jumpSpeed;
            }
        }

        moveDirection.y -= gravity * Time.deltaTime;

        characterController.Move(moveDirection * Time.deltaTime);
    }
}
