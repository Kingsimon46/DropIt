using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {


    private float movingDistance = 0.2f;

    //Maximale Auslenkung beim Bewegen in die vier Richtungen.
    private float maxUpDistance = 1.1f;
    private float maxDownDistance = -1.1f;
    private float maxLeftDistance = -1.1f;
    private float maxRightDistance = 1.1f;


    // Use this for initialization
    void Start () {
	
	

	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey(KeyCode.UpArrow))
        {
            if (maxUpDistance - movingDistance >= transform.position.z)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + movingDistance);
                
                Debug.Log("UpArrow");
            }
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            if (maxDownDistance + movingDistance <= transform.position.z)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - movingDistance);
            }
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            if (maxLeftDistance + movingDistance <= transform.position.x)
            {
                transform.position = new Vector3(transform.position.x - movingDistance, transform.position.y, transform.position.z);
            }
        }
        if (Input.GetKey(KeyCode.RightArrow))
        { 
            if (maxRightDistance - movingDistance >= transform.position.x) 
                {
                    transform.position = new Vector3(transform.position.x + movingDistance, transform.position.y, transform.position.z);
                }
        }
    }
}