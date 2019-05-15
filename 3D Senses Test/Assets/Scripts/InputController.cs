using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour
{
    public GameObject player; //Player gameobject
    public Transform playerTf;  //Player Transform Variable
    public PlayerMover mover; //Player mover script

    private Vector3 directionToMove;

    // Start is called before the first frame update
    void Start()
    {
        //Initializing Variables
        playerTf = GetComponent<Transform>();
        mover = player.GetComponent<PlayerMover>();
    }

    // Update is called once per frame
    void Update()
    {
    /*    //start the game with the character not moving
        directionToMove = Vector3.zero;

        //if the player presses W, move the character forward
        if (Input.GetKey(KeyCode.W))
        {
            directionToMove += playerTf.forward;
        }

        //if the player presses S, move the character backwards
        if (Input.GetKey(KeyCode.S))
        {
            directionToMove -= playerTf.forward;
        }

        //if the player presses D, strafe the player to the right
        if (Input.GetKey(KeyCode.D))
        {
            directionToMove += playerTf.right;
        }

        //if the player presses A, strafe the player to the left
        if (Input.GetKey(KeyCode.A))
        {
            directionToMove -= playerTf.right;
        }

        //After checking inputs, tell the mover to move in that direction
        mover.PlayerMove(directionToMove); */
    }
}
