using UnityEngine;
using System.Collections;

public class DropCollision : MonoBehaviour {
    
	// Use this for initialization
	void Start () {

    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter(Collision col)
    {
        Debug.Log("Collision!");
        //Debug.Log(col.gameObject.name);
        //Debug.Log(col.gameObject.GetComponent<Renderer>().material.color);

        if (col.transform.GetComponent<Renderer>().material.color == this.GetComponent<Renderer>().material.color)
        {
            Debug.Log("Same Color detected!!");

            // Next drop
            LevelController.StartNewCycle();

        }
        else
        {
            // failed, wrong color
        }
    }
}