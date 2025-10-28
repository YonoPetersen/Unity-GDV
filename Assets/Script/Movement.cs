using UnityEngine;

public class SimpleMovement : MonoBehaviour
{
    public float walkSpeed = 4.0f;
    public float runSpeed = 8.0f;
    public float rotationSpeed = 200.0f;
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        float moveZ = 0f;

        if (Input.GetKey(KeyCode.W))
            moveZ = 1f;
        else if (Input.GetKey(KeyCode.S))
            moveZ = -1f;

        float currentSpeed = moveZ != 0 && Input.GetKey(KeyCode.LeftShift) ? runSpeed : walkSpeed;

        Vector3 moveDir = new Vector3(0, 0, moveZ).normalized;
        transform.Translate(moveDir * currentSpeed * Time.deltaTime, Space.Self);

        float rotation = 0f;
        if (Input.GetKey(KeyCode.A))
            rotation = -1f;
        else if (Input.GetKey(KeyCode.D))
            rotation = 1f;

        transform.Rotate(Vector3.up, rotation * rotationSpeed * Time.deltaTime);

        animator.SetFloat("Speed", moveZ * (currentSpeed / walkSpeed));
    }
}