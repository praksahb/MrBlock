using UnityEngine;

public class PController_transform : MonoBehaviour
{

    void Update()
    {     
        if(Input.GetAxisRaw("Horizontal") > 0)
            transform.position += transform.right * Time.deltaTime;

        if(Input.GetAxisRaw("Horizontal") < 0)
            transform.position -= transform.right * Time.deltaTime;

        if(Input.GetAxisRaw("Vertical") > 0)
            transform.position += transform.up * Time.deltaTime;

        if(Input.GetAxisRaw("Vertical") < 0)
            transform.position -= transform.up * Time.deltaTime;
    }
}
