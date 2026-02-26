using UnityEngine;

public class PlayerRespawn : MonoBehaviour
{
    public static Vector3 lastCheckpointPosition;
    public KeyCode respawnKey = KeyCode.R;

    void Start()
    {
        // Set initial spawn point
        lastCheckpointPosition = transform.position;
        Debug.Log("Start: " + lastCheckpointPosition);
    }

    void Update()
    {
        if (Input.GetKeyDown(respawnKey))
        {
            Debug.Log("R hit");
            GetComponent<CharacterController>().enabled = false;
            transform.position = lastCheckpointPosition;
            Debug.Log("R: " + lastCheckpointPosition + " - " + transform.position);
            GetComponent<CharacterController>().enabled = true;
        }
    }
}