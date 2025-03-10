using UnityEngine;
using UnityEngine.AI;

public class animayion : MonoBehaviour
{
    public Transform player; // مرجع اللاعب
    private NavMeshAgent agent; // التحكم في الحركة
    private Animator animator; // التحكم في الرسوم المتحركة
    public float walkingSpeed = 3.5f; // سرعة الروبوت أثناء المشي
    public float runningSpeed = 6f;   // سرعة الروبوت أثناء الجري
    void Start()
    {
        // الوصول إلى NavMeshAgent و Animator
        agent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (player != null)
        {
            // تحديد وجهة الروبوت إلى موقع اللاعب
            agent.SetDestination(player.position);
            
            // حساب سرعة الروبوت
            float distanceToPlayer = Vector3.Distance(transform.position, player.position);

            // إذا كان الروبوت قريبًا جدًا من اللاعب، اجعله يمشي
            if (distanceToPlayer < 5f)
            {
                agent.speed = walkingSpeed; // تعيين سرعة المشي
            }
            else
            {
                agent.speed = runningSpeed; // تعيين سرعة الجري
            }

            // تحديث متغير السرعة في Animator
            float speed = agent.velocity.magnitude; // حساب السرعة الحالية
            animator.SetFloat("Speed", speed); // تحديث المتغير "Speed"
        }
    }
}
