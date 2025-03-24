using UnityEngine;


public class DoorController : MonoBehaviour
{
    public void OpenDoor()
    {
        // حركة بسيطة لفتح الباب
        // transform.position += new Vector3(0, 0, -10); // مثال لتحريك الباب للخلف
        transform.Translate(0, 0, -10);
    }
}

