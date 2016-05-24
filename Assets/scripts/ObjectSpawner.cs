using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ObjectSpawner : MonoBehaviour {

    public GameObject ObjectToSpawn;
    public Transform generationPoint;
    public ObjectPooler theObjectPool;
 

    // Use this for initialization
    void Start () {
       
        
    }
	
	// Update is called once per frame
	void Update () {
        


    }

    public void spawnNewDrop()
    {
        transform.position = new Vector3(generationPoint.transform.position.x, generationPoint.transform.position.y, generationPoint.transform.position.z);
        //without Objectpooler//
        //Instantiate (ObjectToSpawn, generationPoint.transform.position,transform.rotation);

        GameObject newObject = theObjectPool.GetPooledObject();
        newObject.transform.position = generationPoint.transform.position;
        newObject.transform.rotation = generationPoint.transform.rotation;
       
        newObject.SetActive(true);
    }
       

}
