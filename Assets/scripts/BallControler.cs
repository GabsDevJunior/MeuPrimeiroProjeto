using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using Vector2 = UnityEngine.Vector2;
using Vector3 = UnityEngine.Vector3;

public class BallControler : MonoBehaviour
{
    private Rigidbody2D rb;
    public GameManeger gameManager;
    public EnemyPaddleControl EnemyPaddle;

    public float speedUp = 1.1f;


    public Vector2 startingVelocity = new Vector2(5, 5);
    // Start is called before the first frame update

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Start()
    {
       
    }

    // Update is called once per frame
     public void ResetBall()
    {
        transform.position = Vector3.zero;

        if (rb == null) rb = GetComponent<Rigidbody2D>();
        rb.velocity = startingVelocity;
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("wall"))
        {
            Vector2 newVelocity = rb.velocity;

            newVelocity.y = -newVelocity.y;
            rb.velocity = newVelocity;

        }

        if (collision.gameObject.CompareTag("player")|| (collision.gameObject.CompareTag("Enemy")))
        {
            Vector2 newVelocity = rb.velocity;

            newVelocity.x = -newVelocity.x;
            rb.velocity = newVelocity;

            rb.velocity *= speedUp;
            

        }


        if (collision.gameObject.CompareTag("WallEnemy"))
        {
            gameManager.ScorePlayer();
            ResetBall();
        }
        else if (collision.gameObject.CompareTag("wallPlayer"))
        {
            gameManager.ScoreEnemy();
            ResetBall();
        }
    }
}
