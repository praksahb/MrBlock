using UnityEngine;

public class PController_transform : MonoBehaviour
{
    public int moveSpeed = 5;
    void Update()
    {     
        if(Input.GetAxisRaw("Horizontal") > 0)
            transform.position += transform.right * Time.deltaTime * moveSpeed;

        if(Input.GetAxisRaw("Horizontal") < 0)
            transform.position -= transform.right * Time.deltaTime * moveSpeed;

        if(Input.GetAxisRaw("Vertical") > 0)
            transform.position += transform.up * Time.deltaTime * moveSpeed;

        if(Input.GetAxisRaw("Vertical") < 0)
            transform.position -= transform.up * Time.deltaTime * moveSpeed;
    }
}
