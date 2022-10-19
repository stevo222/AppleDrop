
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] Apples;
    public GameObject[] Obstacles;
    private float xSpawnRange = 6.1f;
    private float ySpawnRange = 6.0f;
    private float appleSpawnTime = 5.0f;
    private float obstacleSpawnTime = 4.0f;
    private float startDelay = 1.5f;
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomApple", startDelay, appleSpawnTime);
        InvokeRepeating("SpawnRandomObstacle", startDelay, obstacleSpawnTime);
    }

     void SpawnRandomApple()
    {
        float randomx = Random.Range(xSpawnRange, -xSpawnRange);
        int randomIndex = Random.Range(0, Apples.Length);

        Vector3 spawnPos = new Vector3(randomx, ySpawnRange);
        Instantiate(Apples[randomIndex], spawnPos, Apples[randomIndex].gameObject.transform.rotation);
    }

    void SpawnRandomObstacle()
    {
        float randomx = Random.Range(xSpawnRange, -xSpawnRange);
        int randomIndex = Random.Range(0, Obstacles.Length);
        Vector3 spawnPos = new Vector3(randomx, ySpawnRange);
        Instantiate(Obstacles[randomIndex], spawnPos, Obstacles[randomIndex].gameObject.transform.rotation);
    }

}
