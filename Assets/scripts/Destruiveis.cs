using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destruiveis : MonoBehaviour
{
    public bool Delay;
    public bool tempo;
    public float ferramentas;
    public Player player;
    public StoneScript stoneScript;
    public float pedra;
    public float tronco;

    public float DestroyDelay = 2.5f; 
    public float DestroyTime = 0;

    protected virtual void Start()
    {
        ferramentas = 1;
        player = FindObjectOfType<Player>();
        

    }
    protected virtual void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            ferramentas += 1;
            if (ferramentas > 4) ferramentas = 1;
            

        }
        if(tempo)
        {
            deelay();
        }
        if (Delay)
        {
            DestroyTime += Time.deltaTime;
        }
    }
    protected virtual void quebrado()
    {
        Debug.Log("quebrado");
        gameObject.SetActive(false);
    
        OnCollect();
    }

    protected virtual void deelay()
    {
        if (DestroyTime > DestroyDelay)
        {

            player.ResetAnim();
            Delay = false;
            player.Break = false;
            DestroyTime = 0;
            quebrado();
        }
    }

    protected virtual void AnimDestroyMe()
    {
        Delay = true;
        player.Break = true;
    }


    protected virtual void OnCollect()
    {

    }
}
