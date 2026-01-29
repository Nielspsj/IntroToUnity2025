using UnityEngine;
using UnityEngine.SceneManagement;

public class Bumper : MonoBehaviour
{
    public int points = 100;
    //public ScoreManager scoreManager; // Reference directly to ScoreManager

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            //scoreManager.AddScore(points);
        }
    }
}
