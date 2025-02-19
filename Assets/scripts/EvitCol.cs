using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EvitCol : MonoBehaviour
{
    public float moveSpeed = 5f; // Velocidade de movimento para cima
<<<<<<< HEAD
    private bool isTouchingLayer13 = false; // Verifica se estï¿½ tocando na camada 13
=======
    private bool isTouchingLayer13 = false; // Verifica se está tocando na camada 13
>>>>>>> 03095ea7e1d6807147ed9ff5b7e6d3979ed59e5b


    void Update()
    {
        if (isTouchingLayer13)
        {
            // Move o Player para cima
            transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);
        }
    }

<<<<<<< HEAD
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Verifica se o objeto estï¿½ na layer 13
=======
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Verifica se o objeto está na layer 13
>>>>>>> 03095ea7e1d6807147ed9ff5b7e6d3979ed59e5b
        if (collision.gameObject.layer == 13)
        {
            isTouchingLayer13 = true;
        }
    }

<<<<<<< HEAD
    private void OnCollisionExit2D(Collision2D collision)
=======
    private void OnTriggerExit2D(Collider2D collision)
>>>>>>> 03095ea7e1d6807147ed9ff5b7e6d3979ed59e5b
    {
        // Para de mover quando o objeto para de encostar na layer 13
        if (collision.gameObject.layer == 13)
        {
            isTouchingLayer13 = false;
        }
    }
}
