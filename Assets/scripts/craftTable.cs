using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class craftTable : MonoBehaviour
{
    public GameObject Craft;

    public treeScript tree;
    public StoneScript stone;
    public Player player;

    private GameObject notAStone2;
    private GameObject notAStone1;

    public GameObject E;
    public GameObject Press;

    void Awake()
    {
        if(E == null)
            {
                notAStone1 = GameObject.Find("NotAStone1");
                E = notAStone1;

            } 
            if(Press == null)
            {
                notAStone2 = GameObject.Find("NotAStone2");
                Press = notAStone2;

            } 
    }

    // Start is called before the first frame update
    void Start()
    {
        Press.SetActive(false);
        E.SetActive(false);
        player = FindObjectOfType<Player>();
        tree = FindObjectOfType<treeScript>();
        stone = FindObjectOfType<StoneScript>();
    }

    // Update is called once per frame
    void Update()
    {
       
    }

  public void craftFlecha()
    
    {
        if (player.treeCounts > 0)
        {
            player.treeCounts--;
           player.flecha += 2;
        }

    }
    public void craftGrade()
    {
        if (player.stoneCounts > 0)
        {
            player.stoneCounts--;
            player.grade += 1;
        }

    }

    public void ExitCraft()
    {
        Craft.SetActive(false);
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if(other.gameObject.layer == 6)
        {
            if(Press != notAStone2)
            {
            Press.SetActive(true);
            E.SetActive(true);
            }
            if(Input.GetKeyDown(KeyCode.E))
            Craft.SetActive(true);
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.layer == 6)
        {
             if(Press != notAStone2)
             {
            Press.SetActive(false);
            E.SetActive(false);
             }
        }
    }


}


