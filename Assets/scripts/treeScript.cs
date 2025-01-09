using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class treeScript : Destruiveis
{
    [Range(0, 1)]
    public float transValue = 0.7f;
    public float transFadeTime = 0.4f;

    private SpriteRenderer SPR;

    private void Awake()
    {
        if(SPR == null)SPR = GetComponent<SpriteRenderer>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<Player>() && gameObject.activeSelf)
        {
            StartCoroutine(FadeTree(SPR, transFadeTime, SPR.color.a, transValue));
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<Player>() && gameObject.activeSelf)
        {
            StartCoroutine(FadeTree(SPR, transFadeTime, SPR.color.a, 1));
        }
    }

    private IEnumerator FadeTree(SpriteRenderer SPTrans, float fadeTime, float StartValue, float targetTrans)
    {

        float timeElapsed = 0;
        while (timeElapsed < fadeTime && gameObject.activeSelf)
        {
            timeElapsed += Time.deltaTime;
            float newAlpha = Mathf.Lerp(StartValue, targetTrans, timeElapsed / fadeTime);
            SPTrans.color = new Color(SPTrans.color.r, SPTrans.color.g, SPTrans.color.b, newAlpha);

            yield return null;
        }
    }

        protected override void quebrado()
    {
        base.quebrado();
    }





    void Tempo()
    {
        tempo = true;
    }





    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 6 && ferramentas == 3)
        {
            Debug.Log("foi");

            if (Input.GetButton("Fire3"))
            {
                Debug.Log("foi de novo");

                AnimDestroyMe();

                if (DestroyTime > DestroyDelay)
                {
                    tronco += 1;
                }
                Tempo();


            }
        }

    }
}
