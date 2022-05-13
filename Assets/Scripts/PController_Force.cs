using UnityEngine;

public class PController_Force : MonoBehaviour
{
    public float moveSpeed;
    public Rigidbody2D rb;

    void FixedUpdate()
    {
        if(Input.GetAxisRaw("Horizontal") > 0)
            rb.AddForce(new Vector2(moveSpeed, 0));

        if (Input.GetAxisRaw("Horizontal") < 0)
            rb.AddForce(new Vector2(-moveSpeed, 0));

        if(Input.GetAxisRaw("Vertical") > 0)
            rb.AddForce(new Vector2(0, moveSpeed));

        if (Input.GetAxisRaw("Vertical") < 0)
            rb.AddForce(new Vector2(0, -moveSpeed));
    }
}
