using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Rigidbody2D rigidbody;
    [SerializeField] float speed;
    [SerializeField] float jumpForce;

    [SerializeField] Transform groundCheck;

    [SerializeField] LayerMask groundLayer;

    [SerializeField] float groundRadius = 0.2f;
    float xMovement;
     
    
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        xMovement = Input.GetAxisRaw("Horizontal");
        // Vector2 movement = new Vector2(xMovement, yMovement).normalized * speed * Time.deltaTime;
        // transform.Translate(movement);


        if (IsGrounded() && Input.GetButtonDown("Jump"))
        {
            rigidbody.velocity = new Vector2(rigidbody.velocity.x, jumpForce);
        }

        if(Input.GetButtonUp("Jump") && rigidbody.velocity.y > 0)
        {
            rigidbody.velocity = new Vector2(rigidbody.velocity.x, rigidbody.velocity.y * 0.2f);
        }

    }

    void FixedUpdate() 
    {
        rigidbody.velocity = new Vector2(xMovement * speed, rigidbody.velocity.y);
    }


    bool IsGrounded() => Physics2D.OverlapCircle(groundCheck.position, groundRadius, groundLayer);


}

