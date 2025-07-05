using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    private float Move;
    public float jump;
    public bool isJumping;
    private Rigidbody2D rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Move = Input.GetAxis("Horizontal");
        rb.linearVelocity = new Vector2(speed * Move, rb.linearVelocity.y);

        if (Input.GetButtonDown("Jump") && isJumping == false)
        {
            rb.AddForce(new Vector2(rb.linearVelocity.x, jump));
            Debug.Log("Jumping");
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isJumping = false;
        }
    }
    
    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isJumping = true;
        }
    }
}