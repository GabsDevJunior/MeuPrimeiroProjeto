using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class StoneScript : MonoBehaviour
{
    public bool isBreaking;
    public float DestroyTime;
    public float DestroyDelay;
    public TreeBase treeBase;
    public Player player;
    public GameObject myTree;
    public GameObject E;
    public GameObject Press;

    public bool colidi;
    public bool Delay;

    public float treeCounts;
    public Text TextTree;


    private void Awake()
    {

        player = FindObjectOfType<Player>();
    }
    private void Start()
    {
        
        Press.SetActive(false);
        E.SetActive(false);
    }

    private void Update()
    {
        if(isBreaking)
        {
            DestroyTime += Time.deltaTime;
            if (DestroyTime >= DestroyDelay)
            {
                isBreaking = false;
            }
        }
        if (colidi)
        {

                treeBase.isReviving = true;
                myTree.SetActive(false);
                player.stoneCounts += 1;
                colidi = false;
            
        }
    }

    
        private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 6)
        {
            Press.SetActive(true);
            E.SetActive(true);
        }
        if (collision.gameObject.layer == 16 )

        {
            if(!isBreaking)
            {
                if (player.ferramentas == 2)
               {
                colidi = true;
                Delay = true;
               }
            }
    }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 6)
        {
            Press.SetActive(false);
            E.SetActive(false);
        }
    }




    


}

