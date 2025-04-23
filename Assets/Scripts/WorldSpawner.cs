using UnityEngine;

public class WorldSpawner : MonoBehaviour
{
    [SerializeField] GameObject worldChunks;
    [SerializeField] float delay;
    [SerializeField] float repeat;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpawnChunk", delay, repeat);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnChunk()
    {
        GameObject chunk = Instantiate(worldChunks, transform.position, Quaternion.identity);
    }
}
