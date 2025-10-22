using UnityEngine;

public class Ex_SimplePlayerPickup : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Pickup"))
        {     
            Destroy(other.gameObject);
        }
    }
}