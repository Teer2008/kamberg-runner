using UnityEngine;

public class MovementController : MonoBehaviour
{
    private Rigidbody2D rb;
    public float jumpForce;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (PlayerControls.Instance.Jump)
        {
            Jump();
        }
    }

    private void Jump()
    {
        rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
    }
}