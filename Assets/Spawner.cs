using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    private Transform spawnsContainer;
    private float timeToLive = 5f;
    private Transform[] spawnPoints;

    public GameObject obsticlePrefab;
    public float spawnTime = 0.3f;

    void Start()
    {
        spawnsContainer = this.gameObject.transform.Find("Spawns");

        var spawnPointContainer = this.gameObject.transform.Find("SpawnPoints");
        spawnPoints = spawnPointContainer.Cast<Transform>().ToArray();
        InvokeRepeating("Spawn", spawnTime, spawnTime);
    }


    void Spawn()
    {
        int spawnPointIndex = Random.Range(0, spawnPoints.Length);

        var obsticle = Instantiate(obsticlePrefab, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
        obsticle.transform.parent = spawnsContainer;

        Destroy(obsticle, timeToLive);
    }
}
