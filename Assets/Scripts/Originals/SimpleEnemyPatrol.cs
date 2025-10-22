using UnityEngine;

public class SimpleEnemyPatrol : MonoBehaviour
{
    public Transform[] waypoints;
    public float speed = 2f;
    private int currentWaypointIndex = 0;

    void Update()
    {
        if (waypoints.Length == 0) return;

        Transform targetWaypoint = waypoints[currentWaypointIndex];
        Vector3 direction = (targetWaypoint.position - transform.position).normalized;

        transform.position += direction * speed * Time.deltaTime;

        // Check if close enough to switch to next waypoint
        if (Vector3.Distance(transform.position, targetWaypoint.position) < 0.2f)
        {
            // Go to next index. Check if we need to start over.
            currentWaypointIndex = currentWaypointIndex + 1;
            if (currentWaypointIndex >= waypoints.Length)
            {
                currentWaypointIndex = 0;
            }
        }
    }
}