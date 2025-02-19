using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class barrier : MonoBehaviour
{
    public AttackCollider attackCollider;
    public int Life;
    public int danoGoMar = 4;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        attackCollider = FindObjectOfType<AttackCollider>();
        OnKill();


    }

public void CreateFloatingText(string message)
{
    GameObject textObject = new GameObject("FloatingText");
    TextMesh textMesh = textObject.AddComponent<TextMesh>();
    textMesh.text = message;
    textMesh.fontSize = 32;
    textMesh.color = Color.yellow;
    textObject.transform.localScale = new Vector3(0.3f, 0.3f, 0.3f);

    textObject.transform.position = transform.position + Vector3.up;
}
    public void Damage(int damage)
    {
        Life -= damage;
    }
    void OnKill()
    {
        if (Life <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.layer == 14)
        {
          
        }
    }

    
    

}
