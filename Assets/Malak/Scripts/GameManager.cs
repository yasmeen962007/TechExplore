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
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject); // Keep GameManager across scenes
        }
        else
        {
            Destroy(gameObject);
        }
    }
    public void SetGameState(GameState newState)
    {
        if (CurrentState == newState) return; // Prevent unnecessary state changes

        CurrentState = newState;
    }

}
