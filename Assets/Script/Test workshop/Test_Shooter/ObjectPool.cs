using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{

    public static ObjectPool SharedInstance; // Singleton instance
    public List<GameObject> pooledObjects;   // List to store pooled objects
    public GameObject objectToPool;          // The prefab to be pooled
    public int amountToPool;                 // Initial amount of objects to pool

    void Awake()
    {
        // Singleton pattern: Ensure only one instance of ObjectPool exists
        if (SharedInstance == null)
        {
            SharedInstance = this;
        }
        else
        {
            Destroy(gameObject); // If an instance already exists, destroy this one
            return;
        }
    }

    void Start()
    {
        // Initialize the list of pooled objects
        pooledObjects = new List<GameObject>();
        GameObject tmp;
        for (int i = 0; i < amountToPool; i++)
        {
            tmp = Instantiate(objectToPool); // Create a new instance of the prefab
            tmp.SetActive(false);            // Set it to inactive initially
            pooledObjects.Add(tmp);          // Add it to the pool
            // Optional: Parent the pooled objects to this ObjectPool GameObject for better organization in Hierarchy
            // tmp.transform.SetParent(this.transform);
        }
    }

    // This is the function from your step 6
    public GameObject GetPooledObject()
    {
        // Loop through the pooled objects
        for (int i = 0; i < amountToPool; i++) // Or use pooledObjects.Count if pool can grow
        {
            // If an object in the pool is not currently active in the scene
            if (!pooledObjects[i].activeInHierarchy)
            {
                return pooledObjects[i]; // Return this inactive object
            }
        }
        // If all objects are currently in use, return null (or you could expand the pool here)
        Debug.LogWarning("Object Pool: All objects are currently in use. Consider increasing amountToPool or implementing dynamic expansion.");
        return null;
    }


}
