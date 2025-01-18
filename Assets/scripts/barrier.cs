using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class barrier : MonoBehaviour
{
    public int Life;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        OnKill();
    }

    public void Damage(int damage)
    {
        damage -= Life;
    }

    void OnKill()
    {
        if (Life <= 0)
        {
            Destroy(gameObject);
        }
    }
}
