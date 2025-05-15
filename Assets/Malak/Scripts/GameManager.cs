using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public enum GameState
    {
        Start,
        Win,
        Lose
    }

    public GameState CurrentState;

    public GameObject winUI; // UI الفوز في مشهد Room فقط

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
            SceneManager.sceneLoaded += OnSceneLoaded;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void SetGameState(GameState newState)
    {
        if (CurrentState == newState) return;
        CurrentState = newState;

        if (newState == GameState.Win)
        {
            TryShowWinUI();
        }
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        if (CurrentState == GameState.Win)
        {
            TryShowWinUI();
        }
    }

    private void TryShowWinUI()
    {
        if (SceneManager.GetActiveScene().name == "Room" && winUI != null)
        {
            winUI.SetActive(true);
        }
    }
}
