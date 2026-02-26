using UnityEngine;

public class SimpleNPCDialogue : MonoBehaviour
{
    public GameObject npcText;
    private bool playerNear = false;

    void Update()
    {
        if (playerNear && Input.GetKeyDown(KeyCode.E))
        {
            npcText.SetActive(!npcText.activeSelf);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerNear = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerNear = false;
            npcText.SetActive(false);
        }
    }
}