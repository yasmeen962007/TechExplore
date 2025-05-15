using UnityEngine;
using UnityEngine.UI;

public class Interactions : MonoBehaviour
{
    public GameObject object3D;
    public Image fadedImage;
    public Image collectedImage;
    public LabManager labManager;

    private bool isCollected = false;

    void Start()
    {
        collectedImage.gameObject.SetActive(false);
    }

    void OnMouseDown()
    {
        if (!isCollected)
        {
            isCollected = true;
            object3D.SetActive(false);
            fadedImage.gameObject.SetActive(false);
            collectedImage.gameObject.SetActive(true);

            labManager.CollectItem();
        }
    }
}