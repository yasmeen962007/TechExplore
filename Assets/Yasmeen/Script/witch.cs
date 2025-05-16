using Fungus;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class witch : MonoBehaviour
{
    public Flowchart flowchart;  // متغير لحفظ الفلو شارت

    // Start is called before the first frame update
    void Start()
    {
        // يمكنك وضع إعدادات مبدئية هنا إن وجدت
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))  // التأكد أن اللاعب دخل منطقة الساحرة
        {
            flowchart.ExecuteBlock("StartDialog");  // تشغيل بلوك الحوار
        }
    }
}