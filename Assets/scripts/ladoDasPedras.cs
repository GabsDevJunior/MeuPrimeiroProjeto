using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ladoDasPedras : Destruiveis
{
    void Tempo()
    {
        tempo = true;
    }





    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 6 && ferramentas == 2)
        {
            Debug.Log("foi");

            if (Input.GetButton("Fire3"))
            {

                Debug.Log("foi de novo");

                AnimDestroyMe();

                if (DestroyTime > DestroyDelay)
                {
                    pedra += 1;
                }
                Tempo();


            }
        }


    }

}
