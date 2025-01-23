using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBase : MonoBehaviour
{
    public Animator anim;
    public float side;
    public Vector3 moviment;

    public bool negativo;

    public barrier Barrier;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(moviment * Time.deltaTime * side);
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

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 12)
        {
            anim.SetTrigger("Breaking");
    
        }
    }
}
