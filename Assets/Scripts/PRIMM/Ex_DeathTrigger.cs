using UnityEngine;

public class Ex_DeathTrigger : MonoBehaviour
{
    public GameManager gameManager;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            gameManager.BallLost();

            Destroy(other.gameObject);
        }
    }
}
