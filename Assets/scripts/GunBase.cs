using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class GunBase : MonoBehaviour
{
    public Player player;
     
    public Animator anim;

    public projetilBase prefeabR;
    public projetilBase prefeabL;

    public Transform positionToShoot;

    public float destroyText;

    public float TimeShoot;

    public bool isFire;
    public bool Left;
    public float arrowns = 20;

    public Transform PlayerReference;

    private Coroutine _correntCoroutine;


    private void Start()
    {
        player = FindObjectOfType<Player>();
        anim = GetComponent<Animator>();
    }
    void Update()
    {

        if(player.flecha < 0)player.flecha = 0;
        if (player.flecha <= 0)
        {
            anim.Play("sem flechas");
        }
        if (player.flecha > 0)
        {
            anim.Play("atirando");
        }
    }








    // Update is called once per frame

    public void isShoot()
    {

        player.flecha -= 1;
        if(!Left)
        {
            var projectile = Instantiate(prefeabR);
            projectile.transform.position = positionToShoot.position;
        }
        if(Left)
        {
            var projectile2 = Instantiate(prefeabL);
            projectile2.transform.position = positionToShoot.position;
        }
    }
    

}