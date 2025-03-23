using Fungus;
using UnityEngine;

public class QuestionTrigger : MonoBehaviour
{
   public Flowchart flowchart;
    public string name;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            flowchart.ExecuteBlock(name); // نفذ Block باسم "Start"
        }
    }
}
