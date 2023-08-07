using UnityEngine;

public class ObjektSpawner : MonoBehaviour
{
    public GameObject objektPrefab; // Das GameObject, das gespawnt werden soll
    public float spawnIntervall = 2f; // Der Zeitabstand zwischen den Spawns in Sekunden
    public int anzahlSpawns = 5; // Die Anzahl der Spawns, die stattfinden sollen

    public float minYPosition = -5f; // Minimale y-Position für den Spawn
    public float maxYPosition = 2f; // Maximale y-Position für den Spawn

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
        float yPosition = Random.Range(minYPosition, maxYPosition);
        GameObject spawnedObjekt = Instantiate(objektPrefab, new Vector3(10f, yPosition, 0f), Quaternion.identity);

        BewegungVonRechtsNachLinksMitRollen bewegungsSkript = spawnedObjekt.GetComponent<BewegungVonRechtsNachLinksMitRollen>();
        if (bewegungsSkript != null)
        {
            bewegungsSkript.geschwindigkeit = geschwindigkeit;
            bewegungsSkript.rollGeschwindigkeit = rollGeschwindigkeit;
        }
    }
}
