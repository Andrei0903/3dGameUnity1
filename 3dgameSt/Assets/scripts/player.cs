using UnityEngine;

public class player : MonoBehaviour
{
	public Rigidbody rb;
	public float forwardForce = 2000f;
	public float silewayForce = 500f; 

	
    // Start is called before the first frame update
   
    
    void FixedUpdate()
    {
    	rb.AddForce(0, 0, forwardForce * Time.deltaTime);
    
    	if (Input.GetKey("d"))
    	{
    		rb.AddForce(silewayForce *Time.deltaTime, 0,0);
    	}
    	if (Input.GetKey("a"))
    	{
    		rb.AddForce(-silewayForce *Time.deltaTime, 0,0);
    	}
    	
    }
}
