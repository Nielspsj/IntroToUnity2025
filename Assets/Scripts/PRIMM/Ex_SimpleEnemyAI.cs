using System.Collections.Generic;
using UnityEngine;

public class Ex_SimpleEnemyAI : MonoBehaviour
{
    [Header("Patrol Settings")]
    public List<Transform> patrolPoints;
    public float patrolSpeed = 2f;

    [Header("Chase Settings")]


    [Header("Attack Settings")]


    private int currentPoint = 0;


    private void Update()
    {
        // Change states here depending on distance to player

        Patrol();       
    }

    void Patrol()
    {
        if (patrolPoints.Count == 0)
        {
            return;
        }

        Transform targetPoint = patrolPoints[currentPoint];
        MoveTowards(targetPoint.position, patrolSpeed);

      
        if (Vector3.Distance(transform.position, targetPoint.position) < 1.0f)
        {
            currentPoint++;
            if (currentPoint >= patrolPoints.Count)
            {
                currentPoint = 0;
            }
        }
    }
    
    void MoveTowards(Vector3 target, float speed)
    {
        Vector3 targetPosition = new Vector3(target.x, transform.position.y, target.z);

        transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
        
        Vector3 direction = (targetPosition - transform.position).normalized;
        direction.y = 0;   

        if (direction != Vector3.zero)
        {
            transform.forward = direction;
        }
    }
}
