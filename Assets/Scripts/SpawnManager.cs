
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] Apples;
    public GameObject[] Obstacles;
    public GameObject[] Clouds;
    private float xSpawnRange = 6.1f;
    private float ySpawnRange = 6.0f;
    private float xcloud = -13.0f;
    private float xcloudi = -12.0f;
    private float ycloud = 8.0f;
    private float ycloudi = -1.0f;
    public float appleSpawnTime = 4.0f;
    public float obstacleSpawnTime = 3.0f;
    public float cloundSpawnTime = 6.0f;
    private float startDelay = 1.5f;
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomApple", startDelay, appleSpawnTime);
        InvokeRepeating("SpawnRandomObstacle", startDelay, obstacleSpawnTime);
        InvokeRepeating("SpwanRandomClouds", startDelay,cloundSpawnTime);
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

    void SpwanRandomClouds()
    {
        float randomx = Random.Range(xcloud, xcloudi);
        float randomy = Random.Range(ycloud, ycloudi);
        int randomIndex = Random.Range(0, Clouds.Length);
        Vector3 spwanPos = new Vector3(randomx, randomy);
        Instantiate(Clouds[randomIndex], spwanPos, Clouds[randomIndex].gameObject.transform.rotation);
    }

}
