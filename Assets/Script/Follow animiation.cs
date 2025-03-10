using UnityEngine;
using UnityEngine.AI;

public class FollowPlayerWithAnimation : MonoBehaviour
{
    public Transform playerTransform; // مرجع للاعب (تم تغيير الاسم)
    private NavMeshAgent _agent; // مرجع إلى NavMeshAgent
    private Animator _animator; // مرجع إلى Animator

    void Start()
    {
        // الوصول إلى NavMeshAgent و Animator
        _agent = GetComponent<NavMeshAgent>();
        _animator = GetComponent<Animator>();
    }

    void Update()
    {
        // إذا كان اللاعب موجودًا
        if (playerTransform != null)
        {
            // تحديد وجهة الروبوت (اللاعب)
            _agent.SetDestination(playerTransform.position);

            // تحديث متغير السرعة بناءً على سرعة الروبوت
            float speed = _agent.velocity.magnitude; // حساب سرعة الروبوت
            _animator.SetFloat("Speed", speed); // تمرير السرعة إلى Animator
        }
    }
}
