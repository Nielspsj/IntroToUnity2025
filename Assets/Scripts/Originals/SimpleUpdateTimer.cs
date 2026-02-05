using UnityEngine;

public class SimpleUpdateTimer : MonoBehaviour
{
    public GameObject effect;
    public float duration = 2f;

    float timer;
    bool running;

    void Start()
    {
        effect.SetActive(true);
        timer = duration;
        running = true;
    }

    void Update()
    {
        if (!running) return;

        timer -= Time.deltaTime;

        if (timer <= 0f)
        {
            effect.SetActive(false);
            running = false;
        }
    }
}
