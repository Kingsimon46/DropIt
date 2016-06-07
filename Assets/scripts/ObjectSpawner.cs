using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ObjectSpawner : MonoBehaviour {
    
    public Transform generationPoint;
    public ObjectPooler objPooler;
    public ColorChanger cChanger;

    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame
	void Update () {

    }

    public void spawnNewDrop(float gravitySpeed)
    {
        transform.position = new Vector3(generationPoint.transform.position.x, generationPoint.transform.position.y, generationPoint.transform.position.z);
        
        GameObject newDrop = objPooler.GetPooledObject();
        newDrop.transform.position = generationPoint.transform.position;
        newDrop.transform.rotation = generationPoint.transform.rotation;
        
        cChanger.ChangeColorOfDrop(newDrop);
        


        objPooler.AddActiveDrop(newDrop);
    }

    public void setDropDeactive(GameObject oldDrop)
    {
        objPooler.RemoveOldestDrop();
    }
}