using UnityEngine;

public class WorldSpawner : MonoBehaviour
{
    [SerializeField] GameObject[] worldChunks;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnChunk()
    {
        int randomIndex = Random.Range(0, worldChunks.Length);
        GameObject chunk = Instantiate(worldChunks[randomIndex], transform.position, Quaternion.identity);
    }
}
