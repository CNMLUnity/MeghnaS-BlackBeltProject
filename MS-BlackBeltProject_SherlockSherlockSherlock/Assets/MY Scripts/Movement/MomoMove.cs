using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class MomoMove : MonoBehaviour
{
    public GameObject Player;
    public PlayerMove PlayerMove;
    public float speed = 10f;
    public NavMeshAgent agent;
    private Animator momo;
    private Animation Walk;
    private Animation Fall;
    private Animation Punch;
    private Animation Kick;
    private Animation Dodge;
    private Animation React;
    private Animation Strangle;
    public GameObject ground;
    public float rotationSpeed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        momo = GetComponent<Animator>();
        momo.SetFloat("MomoSpeed", 10f);
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination (Player.transform.position);
        Vector3 direction = Player.transform.position - transform.position;
        direction.y = 0;
        Quaternion targetRotation = Quaternion.LookRotation(direction);
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
    }
    void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            AttackSherlock();
        }
    }
    private void AttackSherlock()
    {
        int attackTypes = Random.Range(1, 4);
        switch (attackTypes)
        {
            case 1:
                momo.SetBool("MomoPunch", true);
                break;
            case 2:
                momo.SetBool("Hurricane Kick", true);
                break;
            case 3:
                momo.SetBool("Strangle", true);
                break;
        }
        if(PlayerMove.isPunching == true || PlayerMove.isKicking == true)
        {
            int defenseTypes = Random.Range(1, 3);
            switch (defenseTypes)
            {
                case 1:
                    momo.SetBool("Dodge", true);
                    break;
                case 2:
                    momo.SetBool("React", true);
                    break;
            }
        }
    }
    private void FallAndDie()
    {
        if(transform.position.y < 58.92222)
        {
            momo.SetBool("MomoFall", true);
        }
    }
}
