using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class GuardMover : MonoBehaviour
{
    // Guard Mover Variables
    public GuardData data;
    private CharacterController characterController;

    void Start()
    {
        //Initializing Variables
        characterController = GetComponent<CharacterController>();
        //Start the patrol
        MoveToNextWaypoint();
    }

    void Update()
    {
        if (!data.nav.pathPending && data.nav.remainingDistance < 0.5f) //Check if the Nav Agent has a path that's pending
        {
            MoveToNextWaypoint();
        }
    }

    void MoveToNextWaypoint()
    {
        if (data.waypoints.Length > 0)
        {
            //Guard's destination is the current waypoint
            data.nav.destination = data.waypoints[data.currentWaypointIndex].position;

            //Increment waypoint
            data.currentWaypointIndex++;
            //Set Index back to zero when it goes over the max length
            data.currentWaypointIndex %= data.waypoints.Length;
        }
    }
}
