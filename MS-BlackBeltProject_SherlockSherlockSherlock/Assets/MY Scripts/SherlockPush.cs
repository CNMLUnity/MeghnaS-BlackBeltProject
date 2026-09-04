using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class SherlockPush : MonoBehaviour
{
    [Header("Player Dealing Hits")]
    [SerializeField] private float playerAttackForce = 18f;
    [SerializeField] private string enemyTag = "Enemy";

    [Header("Player Receiving Hits (Advantage)")]
    [Tooltip("0.7 means the player only takes 70% of incoming knockback force.")]
    [SerializeField] private float damageResistance = 0.7f;

    private CharacterController controller;
    private Vector3 knockbackVelocity;

    private void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    private void Update()
    {
        // Smoothly decay and apply the knockback movement to the character controller
        if (knockbackVelocity.magnitude > 0.1f)
        {
            controller.Move(knockbackVelocity * Time.deltaTime);
            knockbackVelocity = Vector3.Lerp(knockbackVelocity, Vector3.zero, Time.deltaTime * 8f);
        }
    }

    // Called by the Enemy when they strike the Player
    public void TakeKnockback(Vector3 attackerPosition, float force)
    {
        float finalForce = force * damageResistance; // Apply player advantage

        Vector3 pushDirection = (transform.position - attackerPosition);
        pushDirection.y = 0;
        pushDirection.Normalize();

        knockbackVelocity = pushDirection * finalForce;
    }

    // Detects when the Player strikes the Enemy
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(enemyTag))
        {
            Push enemy = other.GetComponent<Push>();
            if (enemy != null)
            {
                enemy.TakeKnockback(transform.position, playerAttackForce);
            }
        }
    }
}
