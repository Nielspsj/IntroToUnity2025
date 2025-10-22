using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioSource musicSource;   // For background music
    public AudioSource sfxSource;     // For sound effects

    public AudioClip backgroundMusic; // The main music track

    void Start()
    {
        // Play background music at start
        if (musicSource != null && backgroundMusic != null)
        {
            musicSource.clip = backgroundMusic;
            musicSource.loop = true;
            musicSource.Play();
        }
    }

    // Call this from other scripts to play a sound effect
    public void PlaySFX(AudioClip clip)
    {
        if (sfxSource != null && clip != null)
        {
            sfxSource.PlayOneShot(clip);
        }
    }
}
