using UnityEngine;

public class Ex_SoundManager : MonoBehaviour
{
    public AudioSource musicSource;   // For background music
    public AudioSource sfxSource;     // For sound effects

    public AudioClip backgroundMusic; // The main music track

    void Start()
    {
      
    }

    // Call this from other scripts to play a sound effect
    public void PlaySFX(AudioClip clip)
    {
        
    }
}
