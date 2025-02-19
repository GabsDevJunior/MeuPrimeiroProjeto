using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class craftTable : MonoBehaviour
{
<<<<<<< HEAD
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
=======
    public Text flechaCount;
    public Text gradeCount;
    public GameObject Craft;

    public int flecha;
    public int grade;
    public treeScript tree;
    public StoneScript stone;
>>>>>>> 03095ea7e1d6807147ed9ff5b7e6d3979ed59e5b

    // Start is called before the first frame update
    void Start()
    {
<<<<<<< HEAD
        Press.SetActive(false);
        E.SetActive(false);
        player = FindObjectOfType<Player>();
=======
>>>>>>> 03095ea7e1d6807147ed9ff5b7e6d3979ed59e5b
        tree = FindObjectOfType<treeScript>();
        stone = FindObjectOfType<StoneScript>();
    }

    // Update is called once per frame
    void Update()
    {
<<<<<<< HEAD
       
    }

  public void craftFlecha()
    
    {
        if (player.treeCounts > 0)
        {
            player.treeCounts--;
           player.flecha += 2;
=======
        flechaCount.text = flecha.ToString();
        gradeCount.text = grade.ToString();
    }

    public void craftFlecha()
    {
        if (tree.treeCounts > 0)
        {
            tree.treeCounts--;
            flecha += 1;
>>>>>>> 03095ea7e1d6807147ed9ff5b7e6d3979ed59e5b
        }

    }
    public void craftGrade()
    {
<<<<<<< HEAD
        if (player.stoneCounts > 0)
        {
            player.stoneCounts--;
            player.grade += 1;
=======
        if (stone.treeCounts > 0)
        {
            stone.treeCounts--;
            grade += 1;
>>>>>>> 03095ea7e1d6807147ed9ff5b7e6d3979ed59e5b
        }

    }

    public void ExitCraft()
    {
        Craft.SetActive(false);
    }

<<<<<<< HEAD
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


=======
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.layer == 6)
        {
            Craft.SetActive(true);
        }
    }


}
>>>>>>> 03095ea7e1d6807147ed9ff5b7e6d3979ed59e5b
