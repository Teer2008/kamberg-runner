using UnityEngine;

public class ObjektSpawner : MonoBehaviour
{
    public GameObject objektPrefab; // Das GameObject, das gespawnt werden soll
    public float spawnIntervall = 2f; // Der Zeitabstand zwischen den Spawns in Sekunden
    public int anzahlSpawns = 5; // Die Anzahl der Spawns, die stattfinden sollen

    private int spawnCounter = 0;
    private float nextSpawnTime;

    void Start()
    {
        nextSpawnTime = Time.time + spawnIntervall;
    }

    void Update()
    {
        if (spawnCounter < anzahlSpawns && Time.time >= nextSpawnTime)
        {
            SpawnObjekt();
            spawnCounter++;
            nextSpawnTime = Time.time + spawnIntervall;
        }
    }

    void SpawnObjekt()
    {
        Instantiate(objektPrefab, transform.position, Quaternion.identity);
    }
}
