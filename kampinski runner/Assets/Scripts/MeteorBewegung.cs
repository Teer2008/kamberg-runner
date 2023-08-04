using UnityEngine;

public class BewegungVonRechtsNachLinksMitRollen : MonoBehaviour
{
    public float geschwindigkeit = 5f;
    public float minYPosition = 0f;
    public float maxYPosition = 5f;
    public float rollGeschwindigkeit = 100f;

    private float zielXPosition;
    private float zielYPosition;

    void Start()
    {
        // Setze die Zielposition auf der linken Seite des Bildschirms
        zielXPosition = -10f;

        // Setze die zuf�llige vertikale Position
        zielYPosition = Random.Range(minYPosition, maxYPosition);

        // Setze die Startposition auf der rechten Seite des Bildschirms mit der zuf�lligen vertikalen Position
        transform.position = new Vector3(10f, zielYPosition, 0f);
    }

    void Update()
    {
        // Bewege das GameObject von der aktuellen Position zur Zielposition
        transform.position = Vector3.MoveTowards(transform.position, new Vector3(zielXPosition, zielYPosition, 0f), geschwindigkeit * Time.deltaTime);

        // Rotiere das GameObject um seine eigene Achse, um das Rollen zu erzeugen
        transform.Rotate(Vector3.forward * rollGeschwindigkeit * Time.deltaTime);

        // �berpr�fe, ob das GameObject die Zielposition erreicht hat
        if (transform.position.x <= zielXPosition)
        {
            // Zerst�re das GameObject, sobald es die Zielposition erreicht hat
            Destroy(gameObject);
        }
    }
}
