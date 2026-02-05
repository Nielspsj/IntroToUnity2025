using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] private float duration = 2f;
    private float timer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        timer = duration;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if(timer <= 0f)
        {
            //Kjøre instruks
            Debug.Log("timer ran out!");
        }
    }


}
