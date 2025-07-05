using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    float horizontalInput;
    [SerializeField] private float moveSpeed;
    [SerializeField] private float jumpPower;
    bool isJumping = false;
    [SerializeField] private int fruitCount = 0;
    public TextMeshProUGUI fruitText; 
    Rigidbody2D rb;
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
        if (transform.position.y < -10f)
        {
            Debug.Log("Player has fallen off the platform!");
            // Optionally, you can reset the player's position or reload the scene
            // transform.position = new Vector2(0, 0); // Example of resetting position
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); // Reload current scene
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
