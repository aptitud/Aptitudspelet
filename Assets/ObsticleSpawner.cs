using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ObsticleSpawner : MonoBehaviour
{
    private Transform obsticleContainer;
    private float spawnTime = 0.3f;
    private float timeToLive = 5f;
    private Transform[] spawnPoints;

    public GameObject obsticlePrefab;
    
    void Start()
    {
        obsticleContainer = this.gameObject.transform.Find("Obsticles");

        var spawnPointContainer = this.gameObject.transform.Find("SpawnPoints");
        spawnPoints = spawnPointContainer.Cast<Transform>().ToArray();
        InvokeRepeating("Spawn", spawnTime, spawnTime);
    }


    void Spawn()
    {
        // If the player has no health left...
        //if(playerHealth.currentHealth <= 0f)
        //{
        //    // ... exit the function.
        //    return;
        //}

        int spawnPointIndex = Random.Range(0, spawnPoints.Length);

        var obsticle = Instantiate(obsticlePrefab, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
        obsticle.transform.parent = obsticleContainer;

        Destroy(obsticle, timeToLive);
    }
}
