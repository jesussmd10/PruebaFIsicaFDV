using UnityEngine;

public class Script2 : MonoBehaviour
{
    public float moveSpeed = 6f;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float moveX = Input.GetAxis("Horizontal"); 
        float moveZ = Input.GetAxis("Vertical"); 

        Vector3 movement = new Vector3(moveX, 0f, moveZ).normalized;
        Vector3 targetVelocity = movement * moveSpeed;
        targetVelocity.y = rb.linearVelocity.y; 

        // Aplicar la velocidad directamente al Rigidbody
        rb.linearVelocity = targetVelocity;
    }
}