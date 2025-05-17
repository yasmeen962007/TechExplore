using UnityEngine;
using Fungus;

public class RoomManager : MonoBehaviour
{
    public Flowchart startFlowchart;
    public Flowchart winFlowchart;
    public Flowchart loseFlowchart;
    public GameObject finalUI;      // UI بتاع المكسب
    public GameObject gameOverUI;   // UI بتاع الخسارة
    public GameObject playerObject; // اللاعب

    void Start()
    {
        finalUI.SetActive(false);
        gameOverUI.SetActive(false);

        switch (GameManager.instance.CurrentState)
        {
            case GameManager.GameState.Start:
                startFlowchart.ExecuteBlock("StartDialog");
                break;

            case GameManager.GameState.Win:
                winFlowchart.ExecuteBlock("WinDialog");
                finalUI.SetActive(true); // تظهر شاشة المكسب
                break;

            case GameManager.GameState.Lose:
                loseFlowchart.ExecuteBlock("LoseDialog");
                // نحذف Invoke هنا ونعتمد على Fungus ينفذ HandleLose بعد انتهاء الدايلوج
                break;
        }
    }

    // دي هتتدعي من Fungus بعد ما يخلص بلوك LoseDialog
    public void HandleLose()
    {
        if (playerObject != null)
            playerObject.SetActive(false);

        if (gameOverUI != null)
            gameOverUI.SetActive(true); // تظهر شاشة الجيم أوفر
    }
}
