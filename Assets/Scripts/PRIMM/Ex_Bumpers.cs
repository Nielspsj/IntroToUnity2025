using UnityEngine;
using UnityEngine.SceneManagement;

public class Ex_Bumper : MonoBehaviour
{
    public int points = 100;
    //private ScoreManager scoreManager;

    private void Start()
    {
        //scoreManager = FindAnyObjectByType<ScoreManager>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            //scoreManager.AddScore(points);
        }
    }
}
