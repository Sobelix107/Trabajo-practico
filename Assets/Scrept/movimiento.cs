using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimiento : MonoBehaviour
{
    public float movementSpeed = 20;
    public float jumpForce = 5;
    private bool isGrounded;


    public Rigidbody2D rbody; void Jump()
    {
        rbody.velocity = new Vector2(rbody.velocity.x, jumpForce); // Establece la velocidad en el eje Y
       isGrounded = false; // Evita que pueda saltar mientras está en el aire
    }  

    void OnCollisionEnter2D(Collision2D collision)
{
    // Si el objeto colisiona con algo que tiene la etiqueta "Ground", lo consideramos en el suelo
    if (collision.gameObject.CompareTag("Ground"))
    {
        isGrounded = true;
    }
}

    // Start is called before the first frame update
    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rbody.velocity = new Vector2(Input.GetAxis("Horizontal") * movementSpeed, rbody.velocity.y);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
    }
}
