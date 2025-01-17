using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using DG.Tweening;
using UnityEditor;
using Unity.Mathematics;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class Player : MonoBehaviour
{
    public Rigidbody2D rig;
    
    public quaternion initialRotation;

    [Header("Destoy Settings")]
    public float slowAngle = -52f; // Ângulo final do movimento lento
    public float fastAngle = 20f;  // Ângulo final do movimento rápido
    public float slowDuration = 2f; // Tempo para ir lentamente para -52
    public float fastDuration = 0.5f; // Tempo para ir rapidamente para 20
    public bool Break;
    public Destruiveis destruiveis;


    public float forcejump;

  

  

    public Vector2 friction = new Vector2(1f, 0f);

   

    [Header("Animation")]
    public float JumpScaleY = 1.5f;
    public float JumpScaleX = .7f;
    public float GroundAnimationY = 1.5f;
    public float GroundAnimationX = .5f;
    public float AnimationDurationJump;
    public float AnimationDurationGround;
    public Ease ease = Ease.OutBack;

    public bool onJump;
    public bool onDoubleJump;


    [Header("movement")]
    public float speed;
    public float initialspeed;
    public Vector2 movement;
    public bool Right;

    [Header("troca de ferramentas")]
    public float ferramentas;
    public GameObject marreta;
    public GameObject picareta;
    public GameObject machado;
    public GameObject facao;

    public GameObject PrefeabPedra;
    public GameObject PrefeabArvore;





    void Awake()
    {
        initialspeed = speed;
        DOTween.SetTweensCapacity(2000, 1000);
        destruiveis = FindObjectOfType<Destruiveis>();
    }

    private void Start()
    {
        initialRotation = transform.rotation; 
         ferramentas = 1;
    }

    private void Update()
    {
       
        Ferramentas();
        Move();
        jump();
       
    }


    private void Move()
    {

        if (Input.GetKey(KeyCode.D))
        {
            rig.velocity = new Vector2(speed, rig.velocity.y);

        }

        if (Input.GetKey(KeyCode.A))
        {
            rig.velocity = new Vector2(-speed, rig.velocity.y);


        }

        if (rig.velocity.x > 0)
        {
            rig.velocity += friction;
            machado.transform.eulerAngles = new Vector3(0, 0, 0);
            picareta.transform.eulerAngles = new Vector3(0, 0, 0);
            Right = false;


        }

        if (rig.velocity.x < 0)
        {
            rig.velocity -= friction;
            machado.transform.eulerAngles = new Vector3(0, 180, 0);
            picareta.transform.eulerAngles = new Vector3(0, 180, 0);
            Right = true;
        }
    }


    void Ferramentas()
    {
        if(Input.GetKeyDown(KeyCode.LeftShift))
        {
            ferramentas += 1;
            if (ferramentas > 4)ferramentas = 1;

           
        }

        if(ferramentas == 1)
        {
            picareta.SetActive(false);
            machado.SetActive(false);
            facao.SetActive(false);
            marreta.SetActive(true);
        }
        if (ferramentas == 2)
        {
            picareta.SetActive(true);
            machado.SetActive(false);
            facao.SetActive(false);
            marreta.SetActive(false);
        }
        if (ferramentas == 3)
        {
            picareta.SetActive(false);
            machado.SetActive(true);
            facao.SetActive(false);
            marreta.SetActive(false);
        }
        if (ferramentas == 4)
        {
            picareta.SetActive(false);
            machado.SetActive(false);
            facao.SetActive(true);
            marreta.SetActive(false);
        }
    }

    void resetAnim()
    {

        rig.transform.localScale = new Vector2(1, 1);

        DOTween.Kill(rig.transform);
    }
    void jump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (!onJump)
            {
                rig.velocity = Vector2.up * forcejump;
                onJump = true;
                onDoubleJump = false;
                resetAnim();

            }
            else if (!onDoubleJump)
            {
                rig.velocity = Vector2.up * forcejump;
                onDoubleJump = true;
                resetAnim();

            }
        }
    }



    



    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 9)
        {

            resetAnim();


            onJump = false;
            onDoubleJump = true;
        }
    }






    public void animDestroyRigth()
    {
        // Cria uma sequência para controlar os tweens
        DG.Tweening.Sequence leverSequence = DOTween.Sequence(); // Deve funcionar corretamente

        // Movimento lento para -52
        leverSequence.Append(transform.DORotate(new Vector3(0, 0, slowAngle), slowDuration)
            .SetEase(Ease.InOutSine)); // Suavização lenta

        // Movimento rápido para 20
        leverSequence.Append(transform.DORotate(new Vector3(0, 0, fastAngle), fastDuration)
            .SetEase(Ease.OutBack)); // Suavização rápida

        leverSequence.Append(transform.DORotate(new Vector3(0, 0, 0), fastDuration)
            .SetEase(Ease.InOutSine))
        .OnComplete(() =>
         {
             DOTween.Kill(transform);
             speed = initialspeed;
             Debug.Log("Animação concluída!");
         });

        speed = 0;


    }

    public void animDestroyLeft()
    {

        Debug.Log("anim foi chamado");
        // Cria uma sequência para controlar os tweens
        DG.Tweening.Sequence leverSequence = DOTween.Sequence(); // Deve funcionar corretamente

        // Movimento lento para -52
        leverSequence.Append(transform.DORotate(new Vector3(0, 0, -slowAngle), slowDuration)
            .SetEase(Ease.InOutSine)); // Suavização lenta

        // Movimento rápido para 20
        leverSequence.Append(transform.DORotate(new Vector3(0, 0, -fastAngle), fastDuration)
            .SetEase(Ease.OutBack)); // Suavização rápida

        leverSequence.Append(transform.DORotate(new Vector3(0, 0, 0), fastDuration)
            .SetEase(Ease.InOutSine))
            .OnComplete(() =>
            {
                DOTween.Kill(transform);
                speed = initialspeed;
                Debug.Log("Animação concluída!");
            });

        speed = 0;


    }

    public void ResetAnim()
    {
        if (destruiveis.DestroyTime > destruiveis.DestroyDelay)
        {
            speed = initialspeed;
            Debug.Log("Animação resetada!");
        }
    }


    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 7 && Input.GetKeyDown(KeyCode.E))
        {


                animDestroyRigth();
            
        }

        if (collision.gameObject.layer == 8 && Input.GetKeyDown(KeyCode.E))
        {


                animDestroyLeft();
            
        }


    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 7 && Input.GetKeyDown(KeyCode.E))
        {


            animDestroyRigth();

        }

        if (collision.gameObject.layer == 8 && Input.GetKeyDown(KeyCode.E))
        {


            animDestroyLeft();

        }


    }





}




   
