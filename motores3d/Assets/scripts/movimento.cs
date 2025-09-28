using UnityEngine;

using UnityEngine;

public class movimento : MonoBehaviour
{
    public float speed = 5f; 
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
    }

    void FixedUpdate() 
    {
        float moveHorizontal = Input.GetAxis("Horizontal"); 
        float moveVertical = Input.GetAxis("Vertical");     

        Vector3 movement = new Vector3(moveHorizontal, 0, moveVertical);
        rb.linearVelocity = movement * speed; 
    }
}
