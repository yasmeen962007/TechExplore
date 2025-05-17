using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioClip collectSound;
    private AudioSource audioSource;

    void Start()
    {
        audioSource = gameObject.AddComponent<AudioSource>();
    }

    public void PlayCollectSound()
    {
        audioSource.PlayOneShot(collectSound);
    }
}
