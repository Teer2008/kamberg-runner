using UnityEngine;

public class RacingObject : MonoBehaviour
{
    public float speed = 5f; // Geschwindigkeit des Objekts

    void Start()
    {
        // Startposition auf der rechten Seite des Bildschirms festlegen
        float randomY = Random.Range(0f, Screen.height);
        Vector3 startPosition = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, randomY, 10f));
        transform.position = startPosition;
    }

    void Update()
    {
        // Objekt nach links bewegen
        transform.Translate(Vector3.left * speed * Time.deltaTime);

        // Objekt zerstören, wenn es die linke Seite des Bildschirms verlässt
        if (transform.position.x < -Screen.width / 2f)
        {
            Destroy(gameObject);
        }
    }
}
