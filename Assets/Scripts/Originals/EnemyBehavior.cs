using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    //vTest1: Find the player
    //Test2: Distance check to see if the player is in the area
    //Test3: stop moving?
    public List<Transform> waypoints = new List<Transform>();
    private int waypointIndex = 0;
    private float speed = 10f;
    private Vector3 currentTarget;
    private Transform player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        currentTarget = waypoints[waypointIndex].position;
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(transform.position, player.position) > 3f)
        {
            Patrolling();
        }
        else if(Vector3.Distance(transform.position, player.position) <= 3f)
        {
            Attacking();
        }
    }

    private void Patrolling()
    {
        UpdateWaypointMovement();
    }

    private void Attacking()
    {
        //Attacks!
    }


    private void UpdateWaypointMovement()
    {
        Movement();
        if (Vector3.Distance(transform.position, currentTarget) < 0.1f)
        {
            Debug.Log("reached the waypoint!");
            //Update the index to the next one.
            NextWaypointIndex();
            //Store new target.
            currentTarget = waypoints[waypointIndex].position;
        }
    }

    private void NextWaypointIndex()
    {
        //Add to index
        waypointIndex++;
        //Restart index
        if (waypointIndex == waypoints.Count)
        {
            waypointIndex = 0;
        }
    }

    private void Movement()
    {
        transform.position = Vector3.MoveTowards(transform.position, currentTarget, speed * Time.deltaTime);
    }
}
