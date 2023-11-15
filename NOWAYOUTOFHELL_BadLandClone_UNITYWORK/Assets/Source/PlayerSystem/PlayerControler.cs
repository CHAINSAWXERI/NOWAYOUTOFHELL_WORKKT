using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    [SerializeField] public Rigidbody2D rb;
    public float speed;
    public float jumpForce;

    private float MoveInput;
    
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        MoveInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(MoveInput * speed, rb.velocity.y);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //gameObject.transform.rotation.z = 0f;
            rb.angularVelocity = 0f;
            rb.rotation = 5f;
            rb.velocity = Vector2.up * jumpForce;
        }
    }
}
