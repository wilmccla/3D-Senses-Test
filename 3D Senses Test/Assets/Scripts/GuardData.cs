using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class GuardData : MonoBehaviour
{
    [Header("Components")]
    public GuardMover mover;
    public NavMeshAgent nav;

    [Header("Variables")]
    public float moveSpeed;
    public Transform[] waypoints;
    public int currentWaypointIndex = 0;

    void Start()
    {
        nav = GetComponent<NavMeshAgent>();
    }
}
