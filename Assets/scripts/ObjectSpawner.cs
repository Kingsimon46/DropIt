using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ObjectSpawner : MonoBehaviour {
    
    public Transform generationPoint;
    public ObjectPooler objPooler;
    public ColorChanger cChanger;

    private float gravity;
    private float velocity;

    public float speedLimit;
    public float speedIncrease;

    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame
	void FixedUpdate () {
        foreach (GameObject drop in objPooler.GetActiveDrops())
        {
            if (velocity < speedLimit)
            {
                velocity = speedIncrease * gravity;
            }

            Vector3 changeVelocity = new Vector3(0, drop.transform.position.y - velocity, 0);
            drop.transform.position = changeVelocity;
        }
    }

    public void spawnNewDrop(float gravitySpeed)
    {

        gravity = gravitySpeed;

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