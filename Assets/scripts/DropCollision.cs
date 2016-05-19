using UnityEngine;
using System.Collections;

public class DropCollision : MonoBehaviour {


    public LevelController lvlController;


	// Use this for initialization
	void Start () {

        lvlController = GameObject.Find("LevelController").GetComponent<LevelController>();

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

            lvlController.StartNewCycle(gameObject);

        }
        else
        {
            // failed, wrong color
        }
    }
}