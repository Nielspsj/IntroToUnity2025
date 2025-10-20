using UnityEngine;
using UnityEngine.SceneManagement; // Needed for reloading scenes

public class GameManager : MonoBehaviour
{
    public int ballsLeft = 3; // How many balls you start with
    public GameObject ballPrefab;
    public Transform spawnPoint;

    public void BallLost()
    {
        ballsLeft--;

        if (ballsLeft > 0)
        {
            // Spawn a new ball
            Instantiate(ballPrefab, spawnPoint.position, spawnPoint.rotation);
        }
        else
        {
            // No balls left — restart the scene
            Debug.Log("Game Over! Restarting...");
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
