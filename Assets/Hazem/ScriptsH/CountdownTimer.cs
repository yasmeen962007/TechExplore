using UnityEngine;
using UnityEngine.UI;

public class CountdownTimer : MonoBehaviour
{
    public float totalTime = 600f; // 10 minutes
    private float currentTime;
    private bool alarmStarted = false;

    public AudioSource alarmAudio;
    public Text timerText;

    void Start()
    {
        currentTime = totalTime;
    }

    void Update()
    {
        if (currentTime > 0)
        {
            currentTime -= Time.deltaTime;

            // Update UI
            if (timerText != null)
            {
                int minutes = Mathf.FloorToInt(currentTime / 60);
                int seconds = Mathf.FloorToInt(currentTime % 60);
                timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
            }

            // Start looping alarm in last minute
            if (!alarmStarted && currentTime <= 60f)
            {
                alarmAudio.Play();
                alarmStarted = true;
            }
        }
        else
        {
            // Time's up
            currentTime = 0;

            // Stop alarm if it's playing
            if (alarmAudio.isPlaying)
            {
                alarmAudio.Stop();
            }
        }
    }
}
