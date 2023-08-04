using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public float speed = 5f; // Geschwindigkeit des Objekts

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
