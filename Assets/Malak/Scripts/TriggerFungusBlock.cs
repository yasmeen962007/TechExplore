using UnityEngine;
using Fungus;

public class TriggerFungusBlock : MonoBehaviour
{
    public Flowchart flowchart;          // ????? ????? ???? ???
    public string blockNameToExecute;    // ??? ?????? ???? ????? ??????

    public void ActivateDialog()
    {
        if (flowchart != null && !string.IsNullOrEmpty(blockNameToExecute))
        {
            flowchart.ExecuteBlock(blockNameToExecute);
        }
    }
}
