using UnityEngine;

public class AsteroidSpawner : MonoBehaviour
{

    [Header("Mesh Selectors")]
    public GameObject AsteroidPrefab;

    [Header("Spawn Details")]
    public bool StopSpawning = false;
    public float SpawnTime;
    public float SpawnDelay;
    [Header("Asteroid Speed")]
    public float AsteroidSpeed = 10f;
    [Header("Spawn Limits")]
    public float xMin = -10;
    public float xMax = 30;
   

    void Start()
    {
        InvokeRepeating("SpawnObject", SpawnTime, SpawnDelay);   
    }
    void Update()
    {
        // if(Input.GetKeyDown("space"))
        // {
        //     Vector3 spawnPosition = new Vector3(Random.Range(xMin, xMax), 0, 20);
        //     Debug.Log("Asteroid Spawned at: " + spawnPosition);
        //     Instantiate(AsteroidPrefab, spawnPosition, Quaternion.identity);
        // }
        
    }

    public void SpawnObject()
    {
        Vector3 spawnPosition = new Vector3(Random.Range(-10, 20), 0, 60);
        // Debug.Log("Asteroid Spawned at: " + spawnPosition);
        Instantiate(AsteroidPrefab, spawnPosition, Quaternion.identity);
        AsteroidPrefab.GetComponent<AsteroidBehavior>();
        if (StopSpawning)
        {
            CancelInvoke("SpawnObject");
        }
    }
}
