using UnityEngine;
using Fungus;

public class RoomManager : MonoBehaviour
{
    public Flowchart startFlowchart;
    public Flowchart winFlowchart;
    public Flowchart loseFlowchart;

    public GameObject finalUI;       // UI بتاع المكسب
    public GameObject gameOverUI;    // UI بتاع الخسارة
    public GameObject playerObject;  // اللاعب

    public Camera fallbackCamera;    // الكاميرا البديلة اللي هنشغلها وقت الخسارة

    void Start()
    {
        finalUI.SetActive(false);
        gameOverUI.SetActive(false);

        if (fallbackCamera != null)
            fallbackCamera.gameObject.SetActive(false); // نطفيها في الأول

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
                // هنستدعي HandleLose من Fungus بعد انتهاء الدايلوج
                break;
        }
    }

    // دي هتتدعي من Fungus بعد ما يخلص بلوك LoseDialog
    public void HandleLose()
    {
        if (playerObject != null)
            playerObject.SetActive(false);

        if (fallbackCamera != null)
            fallbackCamera.gameObject.SetActive(true); // نشغل الكاميرا البديلة

        if (gameOverUI != null)
            gameOverUI.SetActive(true); // تظهر شاشة الجيم أوفر
    }
}
