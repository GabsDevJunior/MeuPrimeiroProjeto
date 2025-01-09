using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneScript : Destruiveis
{

    protected override void quebrado()
    {
        base.quebrado();
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 6 && ferramentas == 2)
        {
            Debug.Log("foi");

            if (Input.GetButtonDown("Fire3")) // Enquanto o botão está pressionado
            {
                Destroy(gameObject, DestroyDelay);
                    
             }
        }
            
            
   }


    


}

