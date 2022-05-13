using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;
    public Rigidbody2D rb;
    private Vector2 moveDirection;
    public bool isSpacePressed; //initialize to false //will value get reset every frame

    void Update()
    {   
        isSpacePressed = false;
        getInput();
    }

    void FixedUpdate()
    {
        move();
    }

    void getInput()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");
        moveDirection = new Vector2(moveX, moveY).normalized;

        if(Input.GetKey(KeyCode.Space))
            moveDirection = new Vector2(0f, 0f);
    }

    void move()
    {
        rb.velocity = new Vector2(moveDirection.x * moveSpeed, moveDirection.y * moveSpeed);
    }
}
