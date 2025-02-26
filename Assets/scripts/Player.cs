using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine.UI;
using Unity.Mathematics;
using static UnityEngine.RuleTile.TilingRuleOutput;


    public class Player : MonoBehaviour
    {
        [Header("Player Settings")]
        public float speed = 5f;
        public float jumpForce = 10f;
        public float forcejump = 10f;
        public float attackDelay = 0.5f;
        public float attackRange = 1f;
        public float attackDamage = 10f;

        [Header("Destroy Settings")]
        public float slowAngle = -52f;
        public float fastAngle = 20f;
<<<<<<< HEAD
        public float slowDuration = 1f;
        public float fastDuration = 0.3f;
        public GameObject DestroyCollider;

        [Header("Animation")]
        public float jumpScaleY = 1.5f;
        public float jumpScaleX = 0.7f;
        public float groundAnimationY = 1.5f;
        public float groundAnimationX = 0.5f;
        public float animationDurationJump = 0.5f;
        public float animationDurationGround = 0.5f;
        public Ease ease = Ease.OutBack;
        public bool eYes;

        [Header("Movement")]
        public bool isMovingRight = true;
        public bool isJumping = false;
        public bool isDoubleJumping = false;
        public bool isAttacking = false;
        public bool Exit = false;

        [Header("Ferramentas")]
        public int ferramentas = 1;
        public GameObject marreta;
        public GameObject picareta;
        public GameObject machado;
        public GameObject facao;

        [Header("Pedras e Arvores")]
        public GameObject prefebPedra;
        public GameObject prefebArvore;
        public Text TextTree;
        public Text TextStone;
        public int treeCounts;
        public int stoneCounts;
        public int flecha = 40;
        public int grade;
        public Text flechaCount;
        public Text gradeCount;

        private Rigidbody2D rb;
        private Animator animator;
        private Destruiveis destruiveis;
        private float initialJumpForce;
        private float initialSpeed;

        private void Awake()
        {
            isAttacking = false;
            rb = GetComponent<Rigidbody2D>();
            animator = GetComponent<Animator>();
            destruiveis = FindObjectOfType<Destruiveis>();
            initialJumpForce = jumpForce;
            initialSpeed = speed;
        }

        private void Update()
        {
            flechaCount.text = flecha.ToString();
            gradeCount.text = grade.ToString();
            TextTree.text = treeCounts.ToString();
            TextStone.text = stoneCounts.ToString();
            Move();
            Jump();
            Attack();
            Ferramentas();
        }

        private void Move()
        {
            float horizontalInput = Input.GetAxis("Horizontal");
            float verticalInput = Input.GetAxis("Vertical");

            Vector2 movement = new Vector2(horizontalInput, verticalInput);

            if (horizontalInput != 0)
            {
                isMovingRight = horizontalInput > 0;
                rb.velocity = new Vector2(horizontalInput * speed, rb.velocity.y);
            }
            else
            {
                rb.velocity = new Vector2(0, rb.velocity.y);
            }
    if(!isAttacking)
         {
            if (isMovingRight)
            {
                machado.transform.eulerAngles = new Vector3(0, 0, 0);
            }
            else
            {
                machado.transform.eulerAngles = new Vector3(0, 180, 0);
            }
          }
        }
         

        private void Jump()
        {
            if (Input.GetKeyDown(KeyCode.Space) && !isJumping)
            {
                isJumping = true;
                rb.velocity = new Vector2(rb.velocity.x, jumpForce);
                
            }
            else if (Input.GetKeyDown(KeyCode.Space) && isJumping && !isDoubleJumping)
            {
                isDoubleJumping = true;
                rb.velocity = new Vector2(rb.velocity.x, jumpForce);
                
            }
        }

        private void Attack()
        {
            if (Input.GetKeyDown(KeyCode.E) && !isAttacking)
            {
                if (ferramentas == 2 || ferramentas == 3)
            {
                isAttacking = true;
                Debug.Log("Attack");
                if(isMovingRight)
                {
                    animDestroyLeft();
                }
                else
                {
                    animDestroyRigth();
                }
            }
                
                
            }
        }



        private void Ferramentas()
        {
            if (Input.GetKeyDown(KeyCode.LeftShift))
            {
                ferramentas++;
                if (ferramentas > 4) ferramentas = 1;

                switch (ferramentas)
                {
                    case 1:
                        picareta.SetActive(false);
                        machado.SetActive(false);
                        facao.SetActive(false);
                        marreta.SetActive(true);
                        break;
                    case 2:
                        picareta.SetActive(true);
                        machado.SetActive(false);
                        facao.SetActive(false);
                        marreta.SetActive(false);
                        break;
                    case 3:
                        picareta.SetActive(false);
                        machado.SetActive(true);
                        facao.SetActive(false);
                        marreta.SetActive(false);
                        break;
                    case 4:
                        picareta.SetActive(false);
                        machado.SetActive(false);
                        facao.SetActive(true);
                        marreta.SetActive(false);
                        break;
                }
            }
        }

       
=======
        public float slowDuration = 2f;
        public float fastDuration = 0.5f;

        [Header("Animation")]
        public float jumpScaleY = 1.5f;
        public float jumpScaleX = 0.7f;
        public float groundAnimationY = 1.5f;
        public float groundAnimationX = 0.5f;
        public float animationDurationJump = 0.5f;
        public float animationDurationGround = 0.5f;
        public Ease ease = Ease.OutBack;
>>>>>>> 03095ea7e1d6807147ed9ff5b7e6d3979ed59e5b

        [Header("Movement")]
        public bool isMovingRight = true;
        public bool isJumping = false;
        public bool isDoubleJumping = false;
        public bool isAttacking = false;
    public bool Exit = false;

<<<<<<< HEAD


        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.layer == 9)
            {
                isJumping = false;
                isDoubleJumping = false;
            }


        }


            private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.layer == 9)
            {
                isJumping = false;
                isDoubleJumping = false;
            }
=======
        [Header("Ferramentas")]
        public int ferramentas = 1;
        public GameObject marreta;
        public GameObject picareta;
        public GameObject machado;
        public GameObject facao;

        [Header("Pedras e Arvores")]
        public GameObject prefebPedra;
        public GameObject prefebArvore;
        public Text TextTree;
        public Text TextStone;

        private Rigidbody2D rb;
        private Animator animator;
        private Destruiveis destruiveis;
        private float initialJumpForce;
        private float initialSpeed;

        private void Awake()
        {
            rb = GetComponent<Rigidbody2D>();
            animator = GetComponent<Animator>();
            destruiveis = FindObjectOfType<Destruiveis>();
            initialJumpForce = jumpForce;
            initialSpeed = speed;
        }

        private void Update()
        {
            Move();
            Jump();
            Attack();
            Ferramentas();
            Exiting();
        }

        private void Move()
        {
            float horizontalInput = Input.GetAxis("Horizontal");
            float verticalInput = Input.GetAxis("Vertical");
>>>>>>> 03095ea7e1d6807147ed9ff5b7e6d3979ed59e5b

            Vector2 movement = new Vector2(horizontalInput, verticalInput);

<<<<<<< HEAD
        }

          
=======
            if (movement != Vector2.zero)
            {
                isMovingRight = movement.x > 0;
                rb.velocity = new Vector2(movement.x * speed, rb.velocity.y);
            }

            if (isMovingRight)
            {
                machado.transform.eulerAngles = new Vector3(0, 0, 0);
            }
            else
            {
                machado.transform.eulerAngles = new Vector3(0, 180, 0);
            }
        }

        private void Jump()
        {
            if (Input.GetKeyDown(KeyCode.Space) && !isJumping)
            {
                isJumping = true;
                rb.velocity = new Vector2(rb.velocity.x, jumpForce);
                animator.SetTrigger("Jump");
            }
            else if (Input.GetKeyDown(KeyCode.Space) && isJumping && !isDoubleJumping)
            {
                isDoubleJumping = true;
                rb.velocity = new Vector2(rb.velocity.x, jumpForce);
                animator.SetTrigger("DoubleJump");
            }
        }

        private void Attack()
        {
            if (Input.GetKeyDown(KeyCode.E) && !isAttacking)
            {
                isAttacking = true;
                animator.SetTrigger("Attack");
                StartCoroutine(AttackCoroutine());
            }
        }

        private IEnumerator AttackCoroutine()
        {
            yield return new WaitForSeconds(attackDelay);
            isAttacking = false;

            if (ferramentas == 2 || ferramentas == 3)
            {
                RaycastHit2D hit = Physics2D.Raycast(transform.position, isMovingRight ? Vector2.right : Vector2.left, attackRange, LayerMask.GetMask("Enemies"));
 
            }
        }

        private void Ferramentas()
        {
            if (Input.GetKeyDown(KeyCode.LeftShift))
            {
                ferramentas++;
                if (ferramentas > 4) ferramentas = 1;

                switch (ferramentas)
                {
                    case 1:
                        picareta.SetActive(false);
                        machado.SetActive(false);
                        facao.SetActive(false);
                        marreta.SetActive(true);
                        break;
                    case 2:
                        picareta.SetActive(true);
                        machado.SetActive(false);
                        facao.SetActive(false);
                        marreta.SetActive(false);
                        break;
                    case 3:
                        picareta.SetActive(false);
                        machado.SetActive(true);
                        facao.SetActive(false);
                        marreta.SetActive(false);
                        break;
                    case 4:
                        picareta.SetActive(false);
                        machado.SetActive(false);
                        facao.SetActive(true);
                        marreta.SetActive(false);
                        break;
                }
            }
        }

        private void Exiting()
        {
            if (Exit)
            {
                transform.position = Vector2.up * 10 * Time.deltaTime;
            }
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.layer == 9)
            {
                isJumping = false;
                isDoubleJumping = false;
            }
        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.layer == 9)
            {
                isJumping = false;
                isDoubleJumping = false;
            }
        }
>>>>>>> 03095ea7e1d6807147ed9ff5b7e6d3979ed59e5b

        public void ResetAnim()
        {
            isAttacking = false;
            speed = initialSpeed;
            jumpForce = initialJumpForce;
        }

        public void animDestroyRigth()
        {
<<<<<<< HEAD
            
            
            forcejump = 0;
            DG.Tweening.Sequence leverSequence = DOTween.Sequence();

            leverSequence.Append(transform.DORotate(new Vector3(0, 0, slowAngle), 1)
                .SetEase(Ease.InOutSine));

            leverSequence.Append(transform.DORotate(new Vector3(0, 0, fastAngle), 0.3f)
                .SetEase(Ease.OutBack));

            leverSequence.Append(transform.DORotate(new Vector3(0, 0, 0), 0.3f));

             leverSequence.AppendCallback(() => DestroyCollider.SetActive(true))
             
                .SetEase(Ease.InOutSine)
                .OnComplete(() =>
                {
                    
                    DOTween.Kill(transform);
                    speed = initialSpeed;
                    Debug.Log("Anima��o conclu�da!");
                   isAttacking = false;
                    ResetAnim();
                    forcejump = initialJumpForce;
                    
                })
            .AppendInterval(0.4f)
            .AppendCallback(() => DestroyCollider.SetActive(false));

                     

            speed = 0;
            jumpForce = 0;
            
=======
            forcejump = 0;
            DG.Tweening.Sequence leverSequence = DOTween.Sequence();

            leverSequence.Append(transform.DORotate(new Vector3(0, 0, slowAngle), slowDuration)
                .SetEase(Ease.InOutSine));

            leverSequence.Append(transform.DORotate(new Vector3(0, 0, fastAngle), fastDuration)
                .SetEase(Ease.OutBack));

            leverSequence.Append(transform.DORotate(new Vector3(0, 0, 0), fastDuration)
                .SetEase(Ease.InOutSine))
                .OnComplete(() =>
                {
                    DOTween.Kill(transform);
                    speed = initialSpeed;
                    Debug.Log("Anima��o conclu�da!");
                    attack.SetActive(true);
                    ResetAnim();
                    forcejump = initialJumpForce;
                });

            DG.Tweening.Sequence leverSequencePicareta = DOTween.Sequence();

            leverSequencePicareta.Append(picareta.transform.DORotate(new Vector3(0, 0, slowAngle), slowDuration)
                .SetEase(Ease.InOutSine));

            leverSequencePicareta.Append(picareta.transform.DORotate(new Vector3(0, 0, fastAngle), fastDuration)
                .SetEase(Ease.OutBack));

            leverSequencePicareta.Append(picareta.transform.DORotate(new Vector3(0, 0, 0), fastDuration)
                .SetEase(Ease.InOutSine))
                .OnComplete(() =>
                {
                    DOTween.Kill(transform);
                    speed = initialSpeed;
                    Debug.Log("Anima��o conclu�da!");
                    attack.SetActive(true);
                    ResetAnim();
                    forcejump = initialJumpForce;
                });

            speed = 0;
            forcejump = 0;
>>>>>>> 03095ea7e1d6807147ed9ff5b7e6d3979ed59e5b
        }

        public void animDestroyLeft()
        {
<<<<<<< HEAD
           
            
            forcejump = 0;
            DG.Tweening.Sequence leverSequence = DOTween.Sequence();

            leverSequence.Append(transform.DORotate(new Vector3(0, 0, -slowAngle), 1)
                .SetEase(Ease.InOutSine));

            leverSequence.Append(transform.DORotate(new Vector3(0, 0, -fastAngle), 0.3f)
                .SetEase(Ease.OutBack));

            leverSequence.Append(transform.DORotate(new Vector3(0, 0, 0), 0.3f));

                         leverSequence.AppendCallback(() => DestroyCollider.SetActive(true))
             
                .SetEase(Ease.InOutSine)
                .OnComplete(() =>
                {
                    
                    DOTween.Kill(transform);
                    speed = initialSpeed;
                    Debug.Log("Anima��o conclu�da!");
                    ResetAnim();
                    forcejump = initialJumpForce;
                    
                })
                .AppendInterval(0.4f)
            .AppendCallback(() => DestroyCollider.SetActive(false));

           
            speed = 0;
            jumpForce = 0;
            
=======
            forcejump = 0;
            DG.Tweening.Sequence leverSequence = DOTween.Sequence();

            leverSequence.Append(transform.DORotate(new Vector3(0, 0, -slowAngle), slowDuration)
                .SetEase(Ease.InOutSine));

            leverSequence.Append(transform.DORotate(new Vector3(0, 0, -fastAngle), fastDuration)
                .SetEase(Ease.OutBack));

            leverSequence.Append(transform.DORotate(new Vector3(0, 0, 0), fastDuration)
                .SetEase(Ease.InOutSine))
                .OnComplete(() =>
                {
                    DOTween.Kill(transform);
                    speed = initialSpeed;
                    Debug.Log("Anima��o conclu�da!");
                    attack.SetActive(true);
                    ResetAnim();
                    forcejump = initialJumpForce;
                });

            DG.Tweening.Sequence leverSequencePicareta = DOTween.Sequence();

            leverSequencePicareta.Append(picareta.transform.DORotate(new Vector3(0, 0, -slowAngle), slowDuration)
                .SetEase(Ease.InOutSine));

            leverSequencePicareta.Append(picareta.transform.DORotate(new Vector3(0, 0, -fastAngle), fastDuration)
                .SetEase(Ease.OutBack));

            leverSequencePicareta.Append(picareta.transform.DORotate(new Vector3(0, 0, 0), fastDuration)
                .SetEase(Ease.InOutSine))
                .OnComplete(() =>
                {
                    DOTween.Kill(transform);
                    speed = initialSpeed;
                    Debug.Log("Anima��o conclu�da!");
                    attack.SetActive(true);
                    ResetAnim();
                    forcejump = initialJumpForce;
                });

            speed = 0;
            forcejump = 0;
>>>>>>> 03095ea7e1d6807147ed9ff5b7e6d3979ed59e5b
        }
    }


