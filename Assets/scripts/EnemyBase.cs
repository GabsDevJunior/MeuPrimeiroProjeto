using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBase : MonoBehaviour
{
    public Animator anim;
    public float side;
    public Vector3 moviment;

    public int danoGoblinMartelo;

    public bool negativo;

    public barrier Barrier;
    public barrier1 Barrier2;

    public bool attack;
    public float destroyTime;
    public float destroyDelay;
    public bool attack2;

    // Start is called before the first frame update
    void Start()
    {
        Barrier = FindObjectOfType<barrier>();
        Barrier2 = FindObjectOfType<barrier1>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(moviment * Time.deltaTime * side);

        if (attack)
        {
            destroyTime += Time.deltaTime;
            if (destroyTime >= destroyDelay)
            {
                Debug.Log("Attack");
                Barrier.Life -= danoGoblinMartelo;
                destroyTime = 0;
            }
        }

        if (attack2)
        {
            destroyTime += Time.deltaTime;
            if (destroyTime >= destroyDelay)
            {
                Debug.Log("Attack");
                Barrier2.Life -= danoGoblinMartelo;
                destroyTime = 0;
            }
        }
    }

  

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 11)
        {

            moviment = new Vector3(-1, 0, 0);
            transform.eulerAngles = new Vector3(0, 180, 0);
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.gameObject.layer == 12)
        {
            anim.SetTrigger("Breaking");
            attack = true;
            moviment = new Vector3(0, 0, 0);
            
        }

        if (collision.gameObject.layer == 15)
        {
            anim.SetTrigger("Breaking");
            attack2 = true;
            moviment = new Vector3(0, 0, 0);

        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 12)
        {
            anim.SetTrigger("Breaking");

            moviment = new Vector3(1, 0, 0);
        }
        if (collision.gameObject.layer == 15)
        {
            anim.SetTrigger("Breaking");

            moviment = new Vector3(1, 0, 0);
        }
    }
}
