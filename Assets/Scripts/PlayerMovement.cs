using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;
    
    public float forwardForce = 500f;
    public float strafeForce = 500f;

    // FixedUpdate is called a set amount of times (defined in editor) per frame
    void FixedUpdate()
    {
        // Adds a forward force
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if(Input.GetKey("a"))
        {
            rb.AddForce(-strafeForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if(Input.GetKey("d"))
        {
            rb.AddForce(strafeForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if(rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
