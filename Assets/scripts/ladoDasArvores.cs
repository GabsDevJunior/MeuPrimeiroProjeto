using UnityEngine;

public class ladoDasArvores : Destruiveis
{

    private void OnCollisionStay2D(Collision2D collision)
    {
 
            if (collision.gameObject.layer == 6 && Input.GetKeyDown(KeyCode.E))
            {
                Delay = true;
            

                if (DestroyTime >= DestroyDelay)
                {

                    quebrado();
                }

            }
    }
}

