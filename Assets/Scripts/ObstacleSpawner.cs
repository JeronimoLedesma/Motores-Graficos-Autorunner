using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    [SerializeField] GameObject[] obstacleArrangements;
    [SerializeField] float delay;
    [SerializeField] float repeat;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpawnObstacle", delay, repeat);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnObstacle()
    {
        int randomIndex = Random.Range(0, obstacleArrangements.Length);
        GameObject obstacle = obstacleArrangements[randomIndex];
        Instantiate(obstacle);
    }
}
