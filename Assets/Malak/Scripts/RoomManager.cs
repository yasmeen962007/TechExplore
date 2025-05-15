using UnityEngine;
using Fungus;

public class RoomManager : MonoBehaviour
{
    public Flowchart startFlowchart;
    public Flowchart winFlowchart;
    public Flowchart loseFlowchart;

    public GameObject finalUI; // UI ????? ????????

    void Start()
    {
        finalUI.SetActive(false);

        switch (GameManager.instance.CurrentState)
        {
            case GameManager.GameState.Start:
                startFlowchart.ExecuteBlock("StartDialog");
                break;

            case GameManager.GameState.Win:
                winFlowchart.ExecuteBlock("WinDialog");
                finalUI.SetActive(true); // ???? UI
                break;

            case GameManager.GameState.Lose:
                loseFlowchart.ExecuteBlock("LoseDialog");
                break;
        }
    }
}
