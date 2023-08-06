using UnityEngine;

public class LaserObject: MonoBehaviour
{
    public float speed = 10f; // Geschwindigkeit des Lasers

    // Update wird einmal pro Frame aufgerufen
    void Update()
    {
        MoveForward();
    }

    void MoveForward()
    {
        // Der Laser bewegt sich in seiner Vorwärtsrichtung mit der definierten Geschwindigkeit
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
