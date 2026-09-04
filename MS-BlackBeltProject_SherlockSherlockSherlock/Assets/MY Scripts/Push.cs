using UnityEngine;
using UnityEngine.AI;
using System.Collections;

[RequireComponent(typeof(Rigidbody))]
public class Push : MonoBehaviour
{
    [Header("Enemy Dealing Hits")]
    [SerializeField] private float enemyAttackForce = 12f;
    [SerializeField] private string playerTag = "Player";

    private Rigidbody rb;
    private NavMeshAgent agent;
    private bool isKnockedBack = false;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        agent = GetComponent<NavMeshAgent>();
        
        rb.freezeRotation = true; // Stop enemy from rolling like a ball
    }

    // Called by the Player when they strike the Enemy
    public void TakeKnockback(Vector3 attackerPosition, float force)
    {
        if (isKnockedBack) return;
        StartCoroutine(KnockbackRoutine(attackerPosition, force));
    }

    private IEnumerator KnockbackRoutine(Vector3 attackerPosition, float force)
    {
        isKnockedBack = true;

        // Turn off NavMeshAgent so it stops locking the enemy to the floor grid
        if (agent != null && agent.enabled)
        {
            agent.ResetPath();
            agent.enabled = false;
        }

        rb.isKinematic = false;
        rb.linearVelocity = Vector3.zero;

        Vector3 pushDirection = (transform.position - attackerPosition);
        pushDirection.y = 0; 
        pushDirection.Normalize();
        pushDirection.y = 0.2f; // Tiny upward pop to break friction

        rb.AddForce(pushDirection * force, ForceMode.Impulse);

        yield return new WaitForSeconds(0.3f); // Duration of the physical slide

        rb.linearVelocity = Vector3.zero;

        // Safely restore control back to the AI navigation grid
        if (agent != null)
        {
            agent.enabled = true;
        }

        isKnockedBack = false;
    }

    // Detects when the Enemy strikes the Player
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(playerTag))
        {
            SherlockPush player = other.GetComponent<SherlockPush>();
            if (player != null)
            {
                player.TakeKnockback(transform.position, enemyAttackForce);
            }
        }
    }
}
