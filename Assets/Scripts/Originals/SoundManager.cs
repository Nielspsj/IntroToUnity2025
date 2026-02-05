using UnityEngine;

public class SoundManager : MonoBehaviour
{
    [SerializeField] private AudioSource backGroundMusic_AS;
    [SerializeField] private AudioSource SFX_AS;

    void Start()
    {
        backGroundMusic_AS.Play();
    }

    // Call this from other scripts to play a sound effect
    public void PlaySFX(AudioClip clip)
    {
        SFX_AS.PlayOneShot(clip);
    }
}
