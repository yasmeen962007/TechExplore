using UnityEngine;
using UnityEngine.SceneManagement;

public class LabManager : MonoBehaviour
{
    public float timeLimit = 60f;
    private float timer;

    public int totalItems = 3;
    private int collectedItems = 0;

    public GameObject magicPortal;

    private bool winTriggered = false;

    void Start()
    {
        timer = timeLimit;
        magicPortal.SetActive(false); // ??????? ?? ????? ??? ??? ???? ?? ???????
    }

    void Update()
    {
        timer -= Time.deltaTime;

        if (timer <= 0 && !winTriggered)
        {
            if (!AllItemsCollected())
            {
                GameManager.instance.SetGameState(GameManager.GameState.Lose);
                SceneManager.LoadScene("Room");
            }
        }
    }

    public void CollectItem()
    {
        collectedItems++;
        if (collectedItems >= totalItems)
        {
            magicPortal.SetActive(true); // ??????? ???? ??? ???? ???????
        }
    }

    public bool AllItemsCollected()
    {
        return collectedItems >= totalItems;
    }

    public void TriggerWin()
    {
        if (AllItemsCollected())
        {
            winTriggered = true;
            GameManager.instance.SetGameState(GameManager.GameState.Win);
            SceneManager.LoadScene("Room");
        }
    }
}
