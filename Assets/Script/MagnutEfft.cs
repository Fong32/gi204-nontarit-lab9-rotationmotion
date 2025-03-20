using UnityEngine;

public class MagnutEfft : MonoBehaviour
{
    [SerializeField] Vector3 velocity,spin;
     
    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();  

    }

    
    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            kick();
            
        }
        ApplyMagnut();
    }
    void kick()
    {
        rb.linearVelocity = velocity;
        rb.angularVelocity = spin;
    }
    void ApplyMagnut()
    {
        Vector3 magnutforce = Vector3.Cross(rb.linearVelocity,rb.angularVelocity);
        rb.AddForce(magnutforce,ForceMode.Force);
    }
}
