using UnityEngine;

public class ShootingController : MonoBehaviour
{
    public GameObject shootingPoint; // Referenz auf das Objekt, von dem das Projektil ausgeschossen wird
    public GameObject projectilePrefab; // Prefab des Projektils

    public float shootingForce = 10f; // Die Kraft, mit der das Projektil ausgeschossen wird

    // Update wird einmal pro Frame aufgerufen
    void Update()
    {
        // Wenn die linke Maustaste geklickt wird, wird das Projektil ausgeschossen
        if (Input.GetButtonDown("Fire1"))
        {
            ShootProjectile();
        }
    }

    void ShootProjectile()
    {
        // Erstellt eine Instanz des Projektil-Prefabs an der Position und Rotation der shootingPoint-Transform-Komponente
        GameObject newProjectile = Instantiate(projectilePrefab, shootingPoint.transform.position, shootingPoint.transform.rotation);

        // Fügt dem Projektil eine Kraft hinzu, um es in die Richtung des shootingPoint zu bewegen
        Rigidbody projectileRigidbody = newProjectile.GetComponent<Rigidbody>();
        if (projectileRigidbody != null)
        {
            projectileRigidbody.AddForce(shootingPoint.transform.forward * shootingForce, ForceMode.Impulse);
        }
    }
}
