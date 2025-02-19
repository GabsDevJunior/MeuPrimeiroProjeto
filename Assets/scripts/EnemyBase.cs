using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBase : MonoBehaviour
{
    public Animator anim;
    public float side;
    public Vector3 moviment;

<<<<<<< HEAD
    public int dano;
    public int danoForMe;

    public int Life;
=======
    public int danoGoblinMartelo;
>>>>>>> 03095ea7e1d6807147ed9ff5b7e6d3979ed59e5b

    public bool negativo;

    public barrier Barrier;
    public barrier1 Barrier2;

<<<<<<< HEAD
    public bool NoMago;

=======
>>>>>>> 03095ea7e1d6807147ed9ff5b7e6d3979ed59e5b
    public bool attack;
    public float destroyTime;
    public float destroyDelay;
    public bool attack2;
<<<<<<< HEAD
    public bool attacking;
=======
>>>>>>> 03095ea7e1d6807147ed9ff5b7e6d3979ed59e5b

    // Start is called before the first frame update
    protected virtual void Start()
    {
<<<<<<< HEAD
        anim = GetComponent<Animator>();
=======
>>>>>>> 03095ea7e1d6807147ed9ff5b7e6d3979ed59e5b
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

<<<<<<< HEAD
        if(attacking)
        {
            attack = false;
            attack2 = false;
        }

=======
>>>>>>> 03095ea7e1d6807147ed9ff5b7e6d3979ed59e5b
        if (attack)
        {
            destroyTime += Time.deltaTime;
            if (destroyTime >= destroyDelay)
            {
                Debug.Log("Attack");
<<<<<<< HEAD
                Barrier.Damage(dano);
=======
                Barrier.Life -= danoGoblinMartelo;
>>>>>>> 03095ea7e1d6807147ed9ff5b7e6d3979ed59e5b
                destroyTime = 0;
            }
        }

        if (attack2)
        {
            destroyTime += Time.deltaTime;
            if (destroyTime >= destroyDelay)
            {
                Debug.Log("Attack");
<<<<<<< HEAD
                Barrier2.Damage(dano);
=======
                Barrier2.Life -= danoGoblinMartelo;
>>>>>>> 03095ea7e1d6807147ed9ff5b7e6d3979ed59e5b
                destroyTime = 0;
            }
        }
    }

  

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 11)
        {
<<<<<<< HEAD
            moviment = new Vector3(-1, 0, 0);
            transform.eulerAngles = new Vector3(0, 180, 0);
        }
        if(collision.gameObject.layer == 18)
        {
           Damage(1);
            Destroy(collision.gameObject);
        }
=======

            moviment = new Vector3(-1, 0, 0);
            transform.eulerAngles = new Vector3(0, 180, 0);
        }
>>>>>>> 03095ea7e1d6807147ed9ff5b7e6d3979ed59e5b
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
