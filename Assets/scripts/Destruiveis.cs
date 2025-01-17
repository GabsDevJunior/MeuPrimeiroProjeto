using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destruiveis : MonoBehaviour
{
    public bool Delay;
    public bool tempo;
    public float ferramentas;
    public Player player;
    public float pedra;
    public float tronco;

    public float DestroyDelay = 2.5f; 
    public float DestroyTime = 0;

    protected virtual void Start()
    {
        ferramentas = 1;
        player = FindObjectOfType<Player>();
        

    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            ferramentas += 1;
            if (ferramentas > 4) ferramentas = 1;
            

        }
        
    }
    protected virtual void quebrado()
    {

    }


   

    


    protected virtual void OnCollect()
    {

    }
}
