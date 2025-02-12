using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.UIElements;

public class treeScript : MonoBehaviour
{
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


    private void Start()
    {
        TextTree = player.TextTree;
        Press.SetActive(false);
        E.SetActive(false);
        treeBase = FindObjectOfType<TreeBase>();
        player = FindObjectOfType<Player>();
    }

    private void Update()
    {
        if(colidi)
        {  
                treeBase.isReviving = true;
                myTree.SetActive(false);
                treeCounts += 1f;
                TextTree.text = treeCounts.ToString();
                colidi = false;
        }

      

        
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.gameObject.layer == 6)
        {
            Press.SetActive(true);
            E.SetActive(true);
        }
        if (collision.gameObject.layer == 16 && player.ferramentas == 3)

        {
            
                colidi = true;
            
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




