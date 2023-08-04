using UnityEngine;

public class MovementController : MonoBehaviour
{
    private Rigidbody2D rb;
    public float jumpForce;
    private bool isgrounded = true;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (PlayerControls.Instance.Jump && isgrounded)
        {
            Jump();
            isgrounded = false;
        }
    }

    private void Jump()
    {
        rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("ground"))
        {
            isgrounded |= true;
        }
    }
}