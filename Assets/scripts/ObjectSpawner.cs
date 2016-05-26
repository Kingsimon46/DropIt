using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ObjectSpawner : MonoBehaviour {
    
    public Transform generationPoint;
    public ObjectPooler theObjectPool;
    public ColorChanger cChanger;
 

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

        GameObject newDrop = theObjectPool.GetPooledObject();
        newDrop.transform.position = generationPoint.transform.position;
        newDrop.transform.rotation = generationPoint.transform.rotation;

        cChanger.ChangeColorOfDrop(newDrop);

        newDrop.SetActive(true);
    }
}