using UnityEngine;

public class ZombieSpawner : MonoBehaviour
{
    public GameObject zombiePrefab;

    public float timeBtwSpawn;
    public float spawnTime;

    void Start()
    {
        spawnTime = timeBtwSpawn;
    }

    void Update()
    {
        if(spawnTime > 0)
        {
            spawnTime -= Time.deltaTime;
        }
        else
        {
            SpawnZombie();
        }
    }

    void SpawnZombie()
    {
        Instantiate(zombiePrefab, transform.position, Quaternion.identity);
        spawnTime = timeBtwSpawn;
    }
}
