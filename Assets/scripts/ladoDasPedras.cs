using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ladoDasPedras : Destruiveis
{


    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 6 && Input.GetKeyDown(KeyCode.E))
        {
            Delay = true;
            player.ferramentas = 2;

            if (DestroyTime >= DestroyDelay)
            {
                quebrado();
            }

        }
    }


    

}
