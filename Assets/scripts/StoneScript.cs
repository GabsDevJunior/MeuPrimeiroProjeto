using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneScript : MonoBehaviour
{

    public float DestroyTime;
    public float DestroyDelay;
    public TreeBase treeBase;
    public Player player;
    public GameObject myTree;

    public bool colidi;
    public bool Delay;


    private void Start()
    {
     
        player = FindObjectOfType<Player>();
    }

    private void Update()
    {
        if (colidi)
        {
            player.ferramentas = 2;
            if (Delay)
            {
                DestroyTime += Time.deltaTime;
            }
            if (DestroyTime >= DestroyDelay)
            {
                treeBase.isReviving = true;
                DestroyTime = 0;
                myTree.SetActive(false);
                colidi = false;
                Delay = false;
            }
        }




    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 6 && Input.GetKeyDown(KeyCode.E))
        {
            colidi = true;
            Delay = true;
            player.ferramentas = 2;
        }
    }




    


}

