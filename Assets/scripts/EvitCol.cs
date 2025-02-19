using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EvitCol : MonoBehaviour
{
    public float moveSpeed = 5f; // Velocidade de movimento para cima
    private bool isTouchingLayer13 = false; // Verifica se est� tocando na camada 13


    void Update()
    {
        if (isTouchingLayer13)
        {
            // Move o Player para cima
            transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Verifica se o objeto est� na layer 13
        if (collision.gameObject.layer == 13)
        {
            isTouchingLayer13 = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        // Para de mover quando o objeto para de encostar na layer 13
        if (collision.gameObject.layer == 13)
        {
            isTouchingLayer13 = false;
        }
    }
}
