using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class magia : MonoBehaviour
{
    public GameObject[] pedras = new GameObject[4];
    private Vector3 destino;

    void Start()
    {
        pedras = GameObject.FindGameObjectsWithTag("pedra");
        int randomIndex = Random.Range(0, pedras.Length);
        destino = pedras[randomIndex].transform.position;
        Vector3 direction = (destino - transform.position).normalized;
        direction.z = 0; // Ensure the z-axis is not affected
        GetComponent<Rigidbody2D>().velocity = direction * 10f; // Use velocity to reach the target
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("pedra"))
        {
            int index = System.Array.IndexOf(pedras, collision.gameObject);
            if (index >= 0)
            {
                pedras[index].GetComponent<StoneScript>().isBreaking = true;
            }

            Destroy(gameObject);
        }
    }
}
