using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    float horizontalInput;
    float moveSpeed = 5f;
    bool isFacingRight = false;
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
    }
    private void FixedUpdate()
    {
        rb.linearVelocity = new Vector2(horizontalInput * moveSpeed, rb.linearVelocity.y);
    }
    void FlipSprite()
    {
      if(isFacingRight && horizontalInput < 0f || !isFacingRight && horizontalInput > 0f)
      {
          isFacingRight = !isFacingRight;
          Vector3 ls = transform.localScale;
      }
    }
}
