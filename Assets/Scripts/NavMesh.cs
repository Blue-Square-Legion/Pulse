using System;
using System.Collections.Generic;
using System.Threading;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;
using static NavMesh;

public class NavMesh : MonoBehaviour
{
    [SerializeField] public List<Transform> waypoints;
    [SerializeField] public float waypointProximityDistance = 50f; // Distance to waypoint before deactivated
    private NavMeshAgent agent;
    private int currentWaypoint = 0;
    private float distanceToWaypoint;
    private bool carStopped;

    //Car velocity... or speed.
    [SerializeField]  private float decelerationRate = 1f; //will decrease the car's speed by 1 unit per deceleration interval
    [SerializeField] private float decelerationInterval = 0.5f; //the car's speed will decrease every 0.5 seconds
    private float lastUpdateTime = 0f;

    // Car behaviour
    [SerializeField] public CarState currentState;
    [SerializeField] public TrafficSignal currentTrafficSignal;
    public enum TrafficSignal
    {
        None,
        RedLight,
        GreenLight,
        StopSign,
    }
    public enum CarState
    {
        Stopped,
        Moving,
    }

    public void Start()
    {
        currentWaypoint = 0;
        agent = gameObject.GetComponent<NavMeshAgent>();
        agent.speed = 35f;
    }

    public void Update()
    {
        CarMovement();
    }

    // AI Car behavior logic based on current traffic signal
    public void PerformBehavior(TrafficSignal signal)
    {
        currentTrafficSignal = signal;
        switch (currentTrafficSignal)
        {
            case TrafficSignal.None:
                break;
            case TrafficSignal.RedLight:
                StopAtRedLight();
                break;
            case TrafficSignal.StopSign:
                StopAtStopSign();
                break;
            default:
                Console.WriteLine("Unknown traffic signal.");
                break;
        }
    }

    public void CarMovement()
    {
        if (currentState == CarState.Moving)
        {
            agent.speed = 30f;
            distanceToWaypoint = Vector3.Distance(waypoints[currentWaypoint].transform.position, transform.position);
            SetWaypoint();
        }
        else if (currentState == CarState.Stopped)
        {
            float currentTime = Time.time;  // Get current time in seconds
            float elapsedTime = currentTime - lastUpdateTime;

            if (elapsedTime >= decelerationInterval)
            {
                // Decrease speed by deceleration rate
                agent.velocity = agent.velocity.normalized * Mathf.Max(agent.velocity.magnitude - decelerationRate, 0);
                Debug.Log($"Speed: {agent.velocity.magnitude} km/h");

                lastUpdateTime = currentTime;
            }
        }
    }

    public void SetWaypoint()
    {
        if (distanceToWaypoint <= waypointProximityDistance) currentWaypoint++;

        if (currentWaypoint == waypoints.Count) currentWaypoint = 0;
        agent.SetDestination(waypoints[currentWaypoint].transform.position);
    }

    public void StopAtRedLight()
    {
        currentState = CarState.Stopped;
        CarMovement();
    }

    public void StopAtStopSign()
    {
        currentState = CarState.Stopped;
        CarMovement();
    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Road")
        {
            PerformBehavior(TrafficSignal.StopSign);
        }
    }
}