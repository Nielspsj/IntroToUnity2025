using UnityEngine;

public class BumperDetector : MonoBehaviour
{
    private ScoreManager scoreManager;
    private SoundManager soundManager;
    [SerializeField] private int bumperPoints = 100;
    [SerializeField] private float duration = 2f;
    private float timer;
    private bool isRunning = false;
    private Color originalColor;
    private ParticleSystem bumperParticleSystem;
    [SerializeField] private AudioClip bumperSFX;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        scoreManager = GameObject.FindGameObjectWithTag("ScoreManagerTag").GetComponent<ScoreManager>();
        soundManager = GameObject.Find("SoundManager").GetComponent<SoundManager>();
        bumperParticleSystem = GetComponent<ParticleSystem>();
    }
    private void Update()
    {
        if(isRunning == true)
        {
            BumperEffectDelay();
        }
    }

    // Checks for ball hitting collider
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.tag == "Ball")
        {
            scoreManager.AddScore(bumperPoints);
            soundManager.PlaySFX(bumperSFX);
            bumperParticleSystem.Play();            
            originalColor = GetComponent<Renderer>().material.color;
            GetComponent<Renderer>().material.color = Color.red;
            timer = duration;
            isRunning = true;
        }
    }
    private void BumperEffectDelay()
    {
        timer -= Time.deltaTime;
        if (timer <= 0f)
        {
            //Kjøre instruks
            //Debug.Log("timer ran out!");
            GetComponent<Renderer>().material.color = originalColor;
        }
    }
}
