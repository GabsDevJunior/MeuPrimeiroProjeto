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
<<<<<<< HEAD
        
=======
        TextTree = player.TextStone;
>>>>>>> 03095ea7e1d6807147ed9ff5b7e6d3979ed59e5b
        Press.SetActive(false);
        E.SetActive(false);
    }

    private void Update()
    {
        if(isBreaking)
        {
<<<<<<< HEAD
            DestroyTime += Time.deltaTime;
            if (DestroyTime >= DestroyDelay)
            {
                isBreaking = false;
            }
=======

                treeBase.isReviving = true;
                myTree.SetActive(false);
                treeCounts += 1f;
                TextTree.text = treeCounts.ToString();
                colidi = false;
            
>>>>>>> 03095ea7e1d6807147ed9ff5b7e6d3979ed59e5b
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
<<<<<<< HEAD
            if(!isBreaking)
            {
                if (player.ferramentas == 2)
               {
                colidi = true;
                Delay = true;
               }
            }
    }
=======

            if (player.ferramentas == 2)
            {

                colidi = true;
                Delay = true;
            }
        }
>>>>>>> 03095ea7e1d6807147ed9ff5b7e6d3979ed59e5b
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

