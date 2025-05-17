using UnityEngine;
using UnityEngine.UI;

public class Interactions : MonoBehaviour
{
    public GameObject object3D;
    public Image fadedImage;
    public Image collectedImage;
    public LabManager labManager;

    public AudioClip collectSound;
    private AudioSource audioSource;

    private bool isCollected = false;

    void Start()
    {
        collectedImage.gameObject.SetActive(false);
        audioSource = gameObject.AddComponent<AudioSource>();
    }

    void OnMouseDown()
    {
        if (!isCollected)
        {
            isCollected = true;
            object3D.SetActive(false);
            fadedImage.gameObject.SetActive(false);
            collectedImage.gameObject.SetActive(true);

            audioSource.PlayOneShot(collectSound);
            labManager.CollectItem();
        }
    }

    public void ShowCollectedImage()
    {
        collectedImage.gameObject.SetActive(true);
    }
}
