using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackCollider : MonoBehaviour
{
    public int dano;
    void OnTriggerEnter2D(Collider2D collision)
    {

        // Verifica se o objeto colidido tem a tag "Inimigo"
        if (collision.CompareTag("barrier"))
        {
            // Acessa o script do inimigo para causar dano
            var barrier = collision.GetComponent<barrier>();
            if (barrier != null)
            {
                barrier.Damage(dano); // Causa 10 de dano (ou qualquer valor)
            }


        }
    }
}