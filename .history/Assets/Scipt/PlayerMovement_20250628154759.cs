using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    float horizontalInput;
    [SerializeField] private float moveSpeed;
    [SerializeField] private float jumpPower;
    bool isJumping = false;
    [SerializeField] private int fruitCount = 0;
    public textMeshProUGUI fruitText; 
    private Rigidbody2D rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");

        if (Input.GetButtonDown("Jump") && !isJumping)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpPower);
            isJumping = true;
        }
    }
    private void FixedUpdate()
    {
        rb.linearVelocity = new Vector2(horizontalInput * moveSpeed, rb.linearVelocity.y);
    }
      private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isJumping = false;
        }
    }

    public void CollectFruit()
    {
        fruitCount++;
        Debug.Log("Total Fruit : " + fruitCount);
        
        fruitText.text = "Fruit : " + fruitCount;
    }
    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isJumping = true;
        }
    }
}
