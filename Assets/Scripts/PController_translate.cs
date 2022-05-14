using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PController_translate : MonoBehaviour
{
    public float movementSpeed = 1;
    private Vector3 moveDirection;

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
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        moveDirection = new Vector2(x, y); //normalized not required for strafing movements in transform.Translate
    }

    void Move()
    {
        transform.Translate(moveDirection.x * movementSpeed*Time.deltaTime, moveDirection.y * movementSpeed*Time.deltaTime, 0);
    }
}
