using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mago : EnemyBase
{
    public Transform positionToShoot;
    public GameObject prefeab;
    private Vector3 targetPos;

    protected override void Start()
    {
        base.Start();
    }

    protected override void Update()
    {
        base.Update();
    }

    protected override void OnKill()
    {
        base.OnKill();
    }

public void isShoot()
    {

            var projectile = Instantiate(prefeab);
            projectile.transform.position = positionToShoot.position;
        
    }
}
