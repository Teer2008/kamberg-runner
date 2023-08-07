using UnityEngine;

public class SpawnBelowScreen : MonoBehaviour
{
    private Camera mainCamera;
    private Vector2 screenBounds;

    private void Start()
    {
        mainCamera = Camera.main;
        screenBounds = mainCamera.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, mainCamera.transform.position.z));
    }

    private void Update()
    {
        // Überprüfe, ob das GameObject oberhalb des Bildschirms liegt
        if (transform.position.y > screenBounds.y)
        {
            // Setze die Position des GameObjects unterhalb des Bildschirms
            Vector3 newPosition = transform.position;
            newPosition.y = screenBounds.y;
            transform.position = newPosition;
        }
    }
}
