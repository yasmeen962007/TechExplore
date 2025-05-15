using UnityEngine;
using UnityEngine.SceneManagement;

public class FinalGate : MonoBehaviour
{
    public LabManager labManager;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            labManager.TriggerWin();
        }
    }
}