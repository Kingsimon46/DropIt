using UnityEngine;
using System.Collections;

public class DropCollision : MonoBehaviour {


    public LevelController lvlController;
    public HealthManager hManager;

	// Use this for initialization
	void Start () {

        lvlController = GameObject.Find("LevelController").GetComponent<LevelController>();
        hManager = GameObject.Find("HealthManager").GetComponent<HealthManager>();

    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter(Collision col)
    {
        //Debug.Log("Collision!");
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
            Debug.Log("Fail!");
            hManager.ReduceLives();
        }
    }
}