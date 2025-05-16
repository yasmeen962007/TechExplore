using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class helpui : MonoBehaviour
{
    
    public GameObject instructionsImage;

    public void ShowInstructions()
    {
        if (instructionsImage != null)
            instructionsImage.SetActive(true);
    }

    public void HideInstructions()
    {
        if (instructionsImage != null)
            instructionsImage.SetActive(false);
    }
}