using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncePlayerController : MonoBehaviour
{
    public float velocidadMovimiento = 5f;
    public float fuerzaSalto = 7f;

    private Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        float movimientoH = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(movimientoH * velocidadMovimiento, rb.velocity.y);

        if (Input.GetButtonDown("Jump"))
        {
            Jump();
        }
    }

    private void Jump()
    {
        rb.velocity = new Vector2(rb.velocity.x, fuerzaSalto);
    }
}
