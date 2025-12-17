using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class BallMovement : MonoBehaviour
{
    [Header("Controls")]
    public KeyCode forwardKey = KeyCode.W;
    public KeyCode backwardKey = KeyCode.S;
    public KeyCode leftKey = KeyCode.A;
    public KeyCode rightKey = KeyCode.D;

    [Header("Movement")]
    public float moveSpeed = 10f;
    public float maxSpeed = 15f;

    private Rigidbody rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
    }

    void FixedUpdate()
    {
        Move();
        LimitSpeed();
    }

    void Move()
    {
        float x = 0f;
        float z = 0f;

        if (Input.GetKey(leftKey))  x -= 1f;
        if (Input.GetKey(rightKey)) x += 1f;
        if (Input.GetKey(forwardKey))  z += 1f;
        if (Input.GetKey(backwardKey)) z -= 1f;

        Vector3 movement = new Vector3(x, 0f, z).normalized;

        rb.AddForce(movement * moveSpeed, ForceMode.Force);
    }

    void LimitSpeed()
    {
        Vector3 flatVelocity = new Vector3(rb.velocity.x, 0f, rb.velocity.z);

        if (flatVelocity.magnitude > maxSpeed)
        {
            Vector3 limited = flatVelocity.normalized * maxSpeed;
            rb.velocity = new Vector3(limited.x, rb.velocity.y, limited.z);
        }
    }
}
