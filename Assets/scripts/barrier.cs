using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class barrier : MonoBehaviour
{
    public AttackCollider attackCollider;
    public int Life;
    public int danoGoMar = 4;
    public bool attack;
    public float destroyTime;
    public float destroyDelay;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        attackCollider = FindObjectOfType<AttackCollider>();
        OnKill();

        if (attack)
        {
            destroyTime += Time.deltaTime;
            if (destroyTime >= destroyDelay)
            {
                Debug.Log("Attack");
                Life -= danoGoMar;
                destroyTime = 0;
            }
        }
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
          attack = true;
        }
    }

    
    

}
