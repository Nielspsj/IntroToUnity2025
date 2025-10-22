using UnityEngine;
using System.Collections;
using System.Xml.Serialization;

public class Ex_CannonController : MonoBehaviour {
	
	public float deltaAngle = 1.0f;
	float elevationAngle = 0.0f;
	float turnAngle = 0.0f;
	float speed = 2.0f;
	public float muzzleVelocity;
	public GameObject cannonBallPrefab;    
	
	

	void Update () 
	{
        CannonInputs();
        FireCannon();
    }



    void CannonInputs()
	{
        if (Input.GetKey(KeyCode.W))
        {
            elevationAngle -= deltaAngle;
        }
        if (Input.GetKey(KeyCode.S))
        {
            elevationAngle += deltaAngle;
        }
        if (Input.GetKey(KeyCode.A))
        {
            turnAngle -= deltaAngle;
        }
        if (Input.GetKey(KeyCode.D))
        {
            turnAngle += deltaAngle;
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            FireCannon();
        }

  
        Quaternion target = Quaternion.Euler(elevationAngle, turnAngle, 0);
        transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * speed);
    }
	
	void FireCannon() 
    {		
		GameObject muzzle = GameObject.Find("Muzzle");
		GameObject cannonBall = (GameObject)Instantiate(cannonBallPrefab, muzzle.transform.position, muzzle.transform.rotation);
		cannonBall.transform.GetComponent<Rigidbody>().linearVelocity = muzzle.transform.forward*muzzleVelocity;
	}
}
