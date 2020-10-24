using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rig;
    public float fowardForce = 2000f ;
    public float backardForce = 1000f ;
    public float sideForce = 2000f ;

    // Start is called before the first frame update
    void Start()
    {
        //rig.AddForce(0,200,500);
    }

    // Update is called once per frame
    // FixedUpdate is better to handle physics
    void FixedUpdate()
    {
        // You can add ForceMode.VelocityChange to ignore the mass of the object and apply the force without momentum
        if (Input.GetKey("w"))
        {
            rig.AddForce(0, 0, fowardForce * Time.deltaTime);
        }
        if (Input.GetKey("d"))
        {
            rig.AddForce(sideForce * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("s"))
        {
            rig.AddForce(0, 0, -backardForce * Time.deltaTime);
        }
        if (Input.GetKey("a"))
        {
            rig.AddForce(-sideForce * Time.deltaTime,0, 0);
        }
        if (Input.GetKey("space"))
        {
            rig.AddForce(0, fowardForce * Time.deltaTime, 0);        
        }
    }
}
