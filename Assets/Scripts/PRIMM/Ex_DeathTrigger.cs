using UnityEngine;

public class Ex_DeathTrigger : MonoBehaviour
{
    [SerializeField] private Ex_GameManager gameManager;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {

            Destroy(other.gameObject);
            gameManager.BallLost();
        }
    }
}
