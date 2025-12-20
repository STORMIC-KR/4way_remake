using UnityEngine;

public class ZombieSpawner : MonoBehaviour
{
    public GameObject zombiePrefab;
    Zombie zombieScript;

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
        GameObject curZombie = Instantiate(zombiePrefab, transform.position, Quaternion.identity);
        if(curZombie != null)
        {
            zombieScript = curZombie.GetComponent<Zombie>();
        }
        spawnTime = timeBtwSpawn;
    }
}
