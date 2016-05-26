using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ObjectPooler : MonoBehaviour {


    public GameObject pooledObject;

    public int pooledAmount;

    List<GameObject> pooledObjects;
    List<GameObject> activeDrops;

    // Use this for initialization
    void Start () {
        pooledObjects = new List<GameObject>();
        activeDrops = new List<GameObject>();

        for (int i = 0; i < pooledAmount; i++)
        {
            GameObject obj = (GameObject)Instantiate(pooledObject);
            obj.SetActive(false);
            pooledObjects.Add(obj);

        }
    }

    public GameObject GetPooledObject()
    {
        for (int i = 0; i < pooledObjects.Count; i++)
        {
            if (!pooledObjects[i].activeInHierarchy)
            {
                return pooledObjects[i];
            }
        }

        GameObject newObj = (GameObject)Instantiate(pooledObject);
        newObj.SetActive(false);
        pooledObjects.Add(newObj);
        return newObj;

    }

    // Adds a new active drop-gameobject to the activeDrops list
    void AddActiveDrop()
    {

    }

    //Returns all currently active drops
    public List<GameObject> GetActiveDrops()
    {
        return new List<GameObject>();
    }

    // Removes the oldest drop from the "currently active list"
    public void RemoveOldestDrop()
    {

    }
}
