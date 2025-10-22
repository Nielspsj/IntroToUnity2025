using UnityEngine;
using System.Collections;

public class Ex_SimpleSpeedBoost : MonoBehaviour
{
    public float boostAmount = 5f;
    public float boostDuration = 3f;


    void Start()
    {
    }

    public void ActivateBoost()
    {
        StartCoroutine(BoostRoutine());
    }

    IEnumerator BoostRoutine()
    {

        yield return new WaitForSeconds(boostDuration);

    }
}