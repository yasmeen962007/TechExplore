using UnityEngine;

public class ToggleMenu : MonoBehaviour
{
    public GameObject panel;  

    public void TogglePanel()  
    {
        panel.SetActive(!panel.activeSelf); 
    }
}
