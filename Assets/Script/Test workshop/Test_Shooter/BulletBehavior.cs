using UnityEngine;

public class BulletBehavior : MonoBehaviour
{

    public float speed = 20f;        // Speed of the bullet
    public float lifetime = 3f;      // How long the bullet exists before deactivating (seconds)
    private Rigidbody rb;            // Optional: Rigidbody for physics-based movement

    void Awake()
    {
        rb = GetComponent<Rigidbody>(); // Get Rigidbody if you use it
    }

    // OnEnable is called every time the GameObject is set to active
    void OnEnable()
    {
        // Reset any necessary properties when the bullet is reused from the pool
        // For example, reset its velocity if using Rigidbody for movement
        if (rb != null)
        {
            rb.linearVelocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
            // If you set velocity directly after this, this reset might be redundant,
            // but it's good practice for other scenarios.
        }

        // Start a timer to deactivate the bullet after 'lifetime' seconds
        Invoke("Deactivate", lifetime);
    }

    void Update()
    {
        // Example of simple forward movement (if not using Rigidbody for movement)
        if (rb == null || (rb != null && rb.isKinematic)) // If no Rigidbody or it's kinematic
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
    }

    void FixedUpdate()
    {
        // Example of physics-based forward movement (if using a non-kinematic Rigidbody)
        if (rb != null && !rb.isKinematic)
        {
            rb.MovePosition(transform.position + transform.forward * speed * Time.fixedDeltaTime);
            // Or use rb.velocity = transform.forward * speed; (often set once in OnEnable)
        }
    }

    void Deactivate()
    {
        // Deactivate the bullet so it can be reused by the ObjectPool
        gameObject.SetActive(false);
    }

    // OnDisable is called when the GameObject is set to inactive
    void OnDisable()
    {
        // It's good practice to cancel any invokes if the object is disabled
        // for other reasons before the Invoke timer finishes (e.g., on collision)
        CancelInvoke("Deactivate");
    }

    // Example: Deactivate bullet on collision
    void OnCollisionEnter(Collision collision)
    {
        // Add logic here for what happens when the bullet hits something
        // For example, apply damage to the object it hit.
        // Debug.Log("Bullet hit: " + collision.gameObject.name);

        // Deactivate the bullet immediately upon collision
        Deactivate();
    }



}
