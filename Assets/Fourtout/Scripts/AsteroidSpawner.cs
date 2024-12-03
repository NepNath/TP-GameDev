using UnityEngine;

public class AsteroidSpawner : MonoBehaviour
{

    public GameObject AsteroidPrefab;
    public GameObject SpawnLimitLeft;
    public GameObject SpawnLimitRight;

    void Update()
    {
        if(Input.GetKeyDown("space"))
        {
            Vector3 spawnPosition = new Vector3(Random.Range(SpawnLimitLeft, 10), 0, 20);
            Debug.Log("Asteroid Spawned at: " + spawnPosition);
            Instantiate(AsteroidPrefab, spawnPosition, Quaternion.identity);
        }
        
    }


}
