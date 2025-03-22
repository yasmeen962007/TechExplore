using UnityEngine;

public class QuestionTrigger : MonoBehaviour
{
    public Fungus.Flowchart flowchart;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            flowchart.ExecuteBlock("Start"); // نفذ Block باسم "Start"
        }
    }
}
