using UnityEngine;

public class PController_velocity : MonoBehaviour
{
    public float moveSpeed;
    public Rigidbody2D rb;
    private Vector2 moveDirection;

    void Update()
    {   
        GetInput();
    }

    void FixedUpdate()
    {
        Move();
    }

    void GetInput()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");
        moveDirection = new Vector2(moveX, moveY).normalized;

        if(Input.GetKey(KeyCode.Space))
            moveDirection = new Vector2(0f, 0f);
    }

    void Move()
    {
        rb.velocity = new Vector2(moveDirection.x * moveSpeed, moveDirection.y * moveSpeed);
    }
}
