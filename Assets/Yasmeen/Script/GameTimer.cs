using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameTimer : MonoBehaviour
{
    public float totalTime = 420f; // 7 دقائق = 7 × 60 ثانية = 420 ثانية
    private float currentTime;

    public TextMeshProUGUI timerText; // ✅ تم التعديل لاستخدام TextMeshPro

    public AudioSource warningSound;
    public float warningTime = 90f; // تشغيل الصوت عند آخر 30 ثانية

    private bool warningStared = false;

    void Start()
    {
        currentTime = totalTime;
    }

    void Update()
    {
        currentTime -= Time.deltaTime;

        // احسبي الدقايق والثواني
        int minutes = Mathf.FloorToInt(currentTime / 60);
        int seconds = Mathf.FloorToInt(currentTime % 60);

        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);

        // تشغيل الصوت لما الوقت يقرب يخلص
        if (currentTime <= warningTime && !warningStared)
        {
            warningSound.Play();
            warningStared = true;
        }

        // وقف الوقت عند 0
        if (currentTime <= 0)
        {
            currentTime = 0;
            // ممكن تحطي هنا الأكشن لما التايمر يخلص

            if (warningSound.isPlaying)
            {
                warningSound.Stop();
            }
        }
    }
}
