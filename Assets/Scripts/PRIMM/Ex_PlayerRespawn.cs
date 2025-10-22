using UnityEngine;

public class Ex_PlayerRespawn : MonoBehaviour
{
    public static Vector3 lastCheckpointPosition;
    public KeyCode respawnKey = KeyCode.R;

    void Start()
    {
        // Set starting spawn point
        
    }

    void Update()
    {
        if (Input.GetKeyDown(respawnKey))
        {
            // Transport to lastCheckpointPosition
        }
    }

    // Add a respawn method for when the player dies.
}