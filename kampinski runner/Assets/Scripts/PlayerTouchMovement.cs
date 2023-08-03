using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerTouchMovement : MonoBehaviour
{
    public float height;
    private Rigidbody2D rb;
    public float gravity_change;
    public bool onground = true;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Physics.gravity *= gravity_change;
    }

    public void OnJump(InputAction.CallbackContext context)
    {
        if (context.performed && onground)
        {
            Jump();
        }
    }

    private void Jump()
    {
        rb.AddForce(Vector2.up * height, ForceMode2D.Impulse);
        onground = false;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("ground"))
        {
            onground = true;
        }
    }
}