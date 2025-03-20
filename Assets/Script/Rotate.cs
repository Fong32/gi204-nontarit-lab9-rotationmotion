using UnityEngine;

public class Rotate : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] Vector3 angularV,torgue;
    void Start()
    {
      rb = GetComponent<Rigidbody>();  
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rb.angularVelocity = angularV;
        }
        else if (Input.GetMouseButtonDown(1))
        {
            rb.AddTorque(torgue);
        }
        else if(Input.GetKeyDown(KeyCode.Space))
        {
            rb.angularVelocity = Vector3.zero;
        }
     
    }
}
