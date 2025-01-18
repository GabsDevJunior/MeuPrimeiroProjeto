using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBase : MonoBehaviour
{
    public Animator anim;
    public float side;
    public Vector3 moviment;

    public GameObject Attack;
    public barrier Barrier;


    // Start is called before the first frame update
    void Start()
    {
        Attack.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(moviment * Time.deltaTime * side);
    }

    public void AtackActive()
    {
        Attack.SetActive(true);
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
            moviment = new Vector3(0, 0, 0); 
        }
    }
}
