using System.Collections.Generic;
using UnityEngine;

public class SimpleEnemyAI : MonoBehaviour
{
    [Header("Patrol Settings")]
    public List<Transform> patrolPoints; // A list of points to move between
    public float patrolSpeed = 2f;

    [Header("Chase Settings")]
    public Transform player;
    public float chaseRange = 8f;
    public float chaseSpeed = 3.5f;

    [Header("Attack Settings")]
    public float attackRange = 1.5f;
    public float attackCooldown = 1f;

    private int currentPoint = 0;
    private float lastAttackTime = 0f;

    private void Update()
    {
        if (player == null) return; // Safety check

        float distanceToPlayer = Vector3.Distance(transform.position, player.position);

        if (distanceToPlayer <= attackRange)
        {
            AttackPlayer();
        }
        else if (distanceToPlayer <= chaseRange)
        {
            ChasePlayer();
        }
        else
        {
            Patrol();
        }
    }

    void Patrol()
    {
        if (patrolPoints.Count == 0) return; // No patrol points set

        Transform targetPoint = patrolPoints[currentPoint];
        MoveTowards(targetPoint.position, patrolSpeed);

        // If close enough to the target point, move to the next one
        if (Vector3.Distance(transform.position, targetPoint.position) < 0.3f)
        {
            currentPoint++;
            if (currentPoint >= patrolPoints.Count)
            {
                currentPoint = 0; // Loop back to the first point
            }
        }
    }

    void ChasePlayer()
    {
        MoveTowards(player.position, chaseSpeed);
    }

    void AttackPlayer()
    {
        // Wait for cooldown before attacking again
        if (Time.time - lastAttackTime >= attackCooldown)
        {
            Debug.Log("Enemy attacks the player!");
            lastAttackTime = Time.time;
        }
    }

    void MoveTowards(Vector3 target, float speed)
    {
        // Move the enemy toward the target smoothly
        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);

        // Make enemy face the target
        Vector3 direction = (target - transform.position).normalized;
        direction.y = 0;    // to only move on the x and z axis.

        if (direction != Vector3.zero)
        {
            transform.forward = direction;
        }
    }
}
