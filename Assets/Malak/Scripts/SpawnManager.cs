using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    void Start()
    {
        if (PlayerPrefs.GetInt("UseSpawnPoint", 0) == 1) // تحقق هل يجب نقل اللاعب إلى SpawnPoint
        {
            GameObject spawnPoint = GameObject.Find("SpawnPoint"); // ابحث عن الـ SpawnPoint في المشهد
            if (spawnPoint != null)
            {
                transform.position = spawnPoint.transform.position; // انقل اللاعب إلى هناك
            }
            PlayerPrefs.SetInt("UseSpawnPoint", 0); // أعد ضبط المتغير
        }
    }
}