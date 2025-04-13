using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class Projector : MonoBehaviour
{
    public Flowchart flowchart;  // متغير لحفظ الفلو شارت

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))  // التأكد أن اللاعب دخل منطقة الطابعة
        {
            flowchart.ExecuteBlock("ProjectorSay");  // تشغيل بلوك الحوار
        }
    }
}
