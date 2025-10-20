using UnityEngine;
using System.Collections;

public class SimpleSpeedBoost : MonoBehaviour
{
    public float boostAmount = 5f;
    public float boostDuration = 3f;

    private RigidbodyPlayerMovement movementScript;

    void Start()
    {
        movementScript = GetComponent<RigidbodyPlayerMovement>();
    }

    public void ActivateBoost()
    {
        StartCoroutine(BoostRoutine());
    }

    IEnumerator BoostRoutine()
    {
        movementScript.moveSpeed += boostAmount;

        yield return new WaitForSeconds(boostDuration);

        movementScript.moveSpeed -= boostAmount;
    }
}