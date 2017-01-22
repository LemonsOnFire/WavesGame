using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerScript : MonoBehaviour
{
    //public bool isPaused;
    public GameObject car;                // The car prefab to be spawned.
    public float spawnTime = 3f;            // How long between each spawn.
    public Transform[] spawnPoints;         // An array of the spawn points this car can spawn from.
    public float initialDelay = 2f;

    private GameObject spawn;
    private Vector3 position = new Vector3(0, 0, 0);
    private Quaternion rotation = new Quaternion(0, 0, 0, 0);

    void Start()
    {
        globalValues.isPaused = false;
        spawn = this.gameObject;
        
        // Call the Spawn function after a delay of the spawnTime and then continue to call after the same amount of time.
        InvokeRepeating("Spawn", initialDelay, spawnTime);

    }


    void Spawn()
    {
        // If the game is paused...
        if (globalValues.isPaused)
        {
            // ... exit the function.
            return;
        }
        
        // Find a random index between zero and one less than the number of spawn points.
        int spawnPointIndex = Random.Range(0, spawnPoints.Length);

        // Create an instance of the car prefab at the randomly selected spawn point's position and rotation.
        //Example  Instantiate(car, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
        Instantiate(car, spawn.transform.position, spawn.transform.rotation, spawn.transform);
    }
}