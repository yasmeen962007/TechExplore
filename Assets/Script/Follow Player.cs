using UnityEngine;
using UnityEngine.AI;

public class animayion : MonoBehaviour
{
    public Transform player; // مرجع اللاعب
    private NavMeshAgent agent; // التحكم في الحركة
    private Animator anim; // التحكم في الرسوم المتحركة
    public float walkingSpeed = 3.5f; // سرعة الروبوت أثناء المشي
    public float runningSpeed = 6f;   // سرعة الروبوت أثناء الجري
    public float Speed;
    public float allowPlayerRotation = 0.1f;
    [Range(0, 1f)]
    public float StartAnimTime = 0.3f;
    [Range(0, 1f)]
    public float StopAnimTime = 0.15f;
    void Start()
    {
        // الوصول إلى NavMeshAgent و Animator
        agent = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();
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
            //animator.SetFloat("Speed", speed); // تحديث المتغير "Speed"
            if (speed > allowPlayerRotation)
            {
                anim.SetFloat("Blend", speed, StartAnimTime, Time.deltaTime);
               // PlayerMoveAndRotation();
            }
            else if (speed < allowPlayerRotation)
            {
                anim.SetFloat("Blend", speed, StopAnimTime, Time.deltaTime);
            }
        }
    }
}
