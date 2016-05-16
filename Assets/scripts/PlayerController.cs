using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {


    private float movingDistance = 0.333f;
    

    // Use this for initialization
    void Start () {
	
	

	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + movingDistance);
            Debug.Log("UpArrow");
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - movingDistance);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position = new Vector3(transform.position.x - movingDistance, transform.position.y, transform.position.z);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position = new Vector3(transform.position.x + movingDistance, transform.position.y, transform.position.z);
        }
    }
}