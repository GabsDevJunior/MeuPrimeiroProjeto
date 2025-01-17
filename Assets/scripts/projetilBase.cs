using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class projetilBase : MonoBehaviour
{
    public float layerEnemy = 9;
    public float time = 2;
    public Vector3 direction;
    public float side = 1;

    public float cooldown;
    public float fire;



    public int dano = 1;

  

    void Update()
    {

        transform.Translate(direction * Time.deltaTime * side);
    }

    private void Awake()
    {

        Destroy(gameObject, time);

    }


}
