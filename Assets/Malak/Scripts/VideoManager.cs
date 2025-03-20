using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class VideoManager : MonoBehaviour
{
    public VideoPlayer videoPlayer; // ربط فيديو بلاير

    void Start()
    {
        videoPlayer.loopPointReached += OnVideoEnd; // تشغيل الدالة عند انتهاء الفيديو
    }

    void OnVideoEnd(VideoPlayer vp)
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); // الانتقال للمشهد التالي
    }
}

