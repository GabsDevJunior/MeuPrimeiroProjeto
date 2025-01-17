using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class GunBase : MonoBehaviour
{
    public Animator anim;

    public projetilBase prefeab;

    public Transform positionToShoot;

    public float TimeShoot;

    public bool isFire;
    public float arrowns = 20;

    public Transform PlayerReference;

    private Coroutine _correntCoroutine;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }
    void Update()
    {
        if (arrowns == 0)
        {
            anim.Play("sem flechas");
        }
        if (arrowns != 0)
        {
            anim.Play("atirando");
        }
    }
    // Update is called once per frame

    public void isShoot()
    {

        arrowns -= 1;
            var projectile = Instantiate(prefeab);
            projectile.transform.position = positionToShoot.position;
        
    }
    

}