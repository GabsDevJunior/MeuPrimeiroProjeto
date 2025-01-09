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
 


    [Header("movement")]
    public float speed;
    public float initialspeed;
    public Vector2 movement;

    [Header("troca de ferramentas")]
    public float ferramentas;
    public GameObject marreta;
    public GameObject picareta;
    public GameObject machado;
    public GameObject facao;

    public GameObject PrefeabPedra;
    public GameObject PrefeabArvore;

    public Ease ease;




    void Awake()
    {
        initialspeed = speed;
        DOTween.SetTweensCapacity(2000, 1000);
    }

    private void Start()
    {
        initialRotation = transform.rotation; 
         ferramentas = 1;
    }

    private void Update()
    {
       
        Ferramentas();
        if(speed > 0)
        {
            transform.eulerAngles = new Vector3(0, 0, 0);        
        }

        if (speed < 0)
        {
            transform.eulerAngles = new Vector3(0, 180, 0);
        }
        movement = new Vector2 (Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
    }

    private void FixedUpdate()
    {
        rig.MovePosition(rig.position + movement * speed * Time.fixedDeltaTime);
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
            .SetEase(Ease.InOutSine));

        speed = 0;


    }

    public void animDestroyLeft()
    {
        // Cria uma sequência para controlar os tweens
        DG.Tweening.Sequence leverSequence = DOTween.Sequence(); // Deve funcionar corretamente

        // Movimento lento para -52
        leverSequence.Append(transform.DORotate(new Vector3(0, 0, -slowAngle), slowDuration)
            .SetEase(Ease.InOutSine)); // Suavização lenta

        // Movimento rápido para 20
        leverSequence.Append(transform.DORotate(new Vector3(0, 0, -fastAngle), fastDuration)
            .SetEase(Ease.OutBack)); // Suavização rápida

        leverSequence.Append(transform.DORotate(new Vector3(0, 0, 0), fastDuration)
            .SetEase(Ease.InOutSine));

        speed = 0;


    }

    public void ResetAnim()
    {
        speed = initialspeed;
        Debug.Log("Animação resetada!");
        transform.rotation = initialRotation;
        DOTween.Kill(transform.rotation);
    }


    

}
   
