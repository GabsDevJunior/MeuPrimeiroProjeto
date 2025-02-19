using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBase : MonoBehaviour
{
    public Animator anim;
    public float side;
    public Vector3 moviment;

    public int dano;
    public int danoForMe;

    public int Life;

    public bool negativo;

    public barrier Barrier;
    public barrier1 Barrier2;

    public bool NoMago;

    public bool attack;
    public float destroyTime;
    public float destroyDelay;
    public bool attack2;
    public bool attacking;

    // Start is called before the first frame update
    protected virtual void Start()
    {
        anim = GetComponent<Animator>();
        Barrier = FindObjectOfType<barrier>();
        Barrier2 = FindObjectOfType<barrier1>();
    }

    public void Damage(int damage)
    {
        Life -= damage;
    }

       protected virtual void OnKill()
    {
        if (Life <= 0)
        {
            Destroy(gameObject);
        }
    }
    // Update is called once per frame
    protected virtual void Update()
    {
        if(NoMago)transform.position = new Vector3(transform.position.x, -5.56f, transform.position.z);
        if(!NoMago)transform.position = new Vector3(transform.position.x, -5.05f, transform.position.z);
        OnKill();
        transform.Translate(moviment * Time.deltaTime * side);

        if(attacking)
        {
            attack = false;
            attack2 = false;
        }

        if (attack)
        {
            destroyTime += Time.deltaTime;
            if (destroyTime >= destroyDelay)
            {
                Debug.Log("Attack");
                Barrier.Damage(dano);
                destroyTime = 0;
            }
        }

        if (attack2)
        {
            destroyTime += Time.deltaTime;
            if (destroyTime >= destroyDelay)
            {
                Debug.Log("Attack");
                Barrier2.Damage(dano);
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
        if(collision.gameObject.layer == 18)
        {
           Damage(1);
            Destroy(collision.gameObject);
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
