using UnityEngine;
using UnityEngine.SceneManagement; // Needed for reloading scenes

public class Ex_GameManager : MonoBehaviour
{
    public int ballsLeft = 3; // How many balls you start with
    [SerializeField] private GameObject ballPrefab;
    [SerializeField] private Transform spawnPoint;

    // Run when we lose a ball. Spawn new ball or reset the scene.
    public void BallLost()
    {
        if(ballsLeft > 100)
        {

        }
        else
        {

        }
    }
}
