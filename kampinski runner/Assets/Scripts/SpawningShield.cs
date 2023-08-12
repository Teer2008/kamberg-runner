using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawningShield : MonoBehaviour
{
    [SerializeField] GameObject warningshieldPrefab;
    [SerializeField] float spawnDelay = 2.0f; // Zeit, nach der das Schild erscheint
    [SerializeField] float despawnDelay = 5.0f; // Zeit, nach der das Schild verschwindet

    private GameObject spawnedShield;

    // Start-Methode
    void Start()
    {
        StartCoroutine(SpawnAndDespawnShield());
    }

    // Coroutine, die das Schild erzeugt und nach einer Zeit wieder zerstört
    IEnumerator SpawnAndDespawnShield()
    {
        // Schild erzeugen
        spawnedShield = Instantiate(warningshieldPrefab, transform.position, Quaternion.identity);

        // Warten bis das Schild erscheint
        yield return new WaitForSeconds(spawnDelay);

        // Schild nach einer Zeit wieder zerstören
        Destroy(spawnedShield, despawnDelay);
    }
}
