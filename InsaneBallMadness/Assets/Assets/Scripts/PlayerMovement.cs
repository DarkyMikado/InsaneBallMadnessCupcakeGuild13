using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour 
{

	float dragSpeed = 20.0f;
 
	void Start ()
	{
       if (rigidbody)
			rigidbody.isKinematic = true;
	}
 
	void Update ()
	{
	    float x = Input.GetAxis ("Mouse X");
	    float z = Input.GetAxis ("Mouse Y");
        transform.Translate (x * Time.deltaTime * dragSpeed, 0.0f, z * Time.deltaTime * dragSpeed, Space.World);
	}
}
