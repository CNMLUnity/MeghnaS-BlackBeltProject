using UnityEngine;
using UnityEngine.AI;
using System.Collections;

public class SherlockPush : MonoBehaviour
{
    public MomoMove MomoMove;
    public GameObject Player;
    public GameObject Enemy;
    public NavMeshAgent moriartyAgent;
    public Animator sherlockAnimator;
    public Animator moriartyAnimator;
    public Transform EnemySyncPoint; // Empty child of Sherlock where Moriarty should stand
    public float syncSpeed = 5f;
    private bool isPushing = false;

    void OnTriggerEnter(Collider other)
    {
        // Trigger the push sequence when they collide
        if (!isPushing && (other.gameObject == Player || other.gameObject == Enemy))
        {
            StartCoroutine(TriggerPushSequence());
        }
    }

    IEnumerator TriggerPushSequence()
    {
        isPushing = true;
        if (MomoMove != null) MomoMove.enabled = false;
        if (moriartyAgent != null) moriartyAgent.enabled = false;
        // Step 1: Stop Moriarty's AI pathfinding
        if (moriartyAgent != null) moriartyAgent.enabled = false;
        
        // Optional: Disable player input for Sherlock here so they can't walk away

        // Step 2: Snap or smoothly slide Moriarty into the ideal grappling position
        float elapsed = 0f;
      // Change this section inside your while loop:
    while (elapsed < 0.5f) 
    {
    // Only move the position toward the sync point
    Enemy.transform.position = Vector3.MoveTowards(
        Enemy.transform.position, 
        EnemySyncPoint.position, 
        syncSpeed * Time.deltaTime
    );
    
    elapsed += Time.deltaTime;
    yield return null;
    }
        // Step 3: Play synchronized struggle/push animations
        moriartyAnimator.SetTrigger("React");
    }
}

