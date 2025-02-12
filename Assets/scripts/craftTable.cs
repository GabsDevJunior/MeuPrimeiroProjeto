using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class craftTable : MonoBehaviour
{
    public Text flechaCount;
    public Text gradeCount;
    public GameObject Craft;

    public int flecha;
    public int grade;
    public treeScript tree;
    public StoneScript stone;

    // Start is called before the first frame update
    void Start()
    {
        tree = FindObjectOfType<treeScript>();
        stone = FindObjectOfType<StoneScript>();
    }

    // Update is called once per frame
    void Update()
    {
        flechaCount.text = flecha.ToString();
        gradeCount.text = grade.ToString();
    }

    public void craftFlecha()
    {
        if (tree.treeCounts > 0)
        {
            tree.treeCounts--;
            flecha += 1;
        }

    }
    public void craftGrade()
    {
        if (stone.treeCounts > 0)
        {
            stone.treeCounts--;
            grade += 1;
        }

    }

    public void ExitCraft()
    {
        Craft.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.layer == 6)
        {
            Craft.SetActive(true);
        }
    }


}
