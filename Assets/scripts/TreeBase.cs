using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeBase : MonoBehaviour
{
    public GameObject tree1;
    public GameObject tree2;
    public GameObject tree3;
    public GameObject tree4;
    public GameObject tree5;
    public GameObject tree6;


    public Transform positionToShoot;

    public float TimeShoot;

    public Transform PlayerReference;

    private Coroutine _correntCoroutine;

    public float TimerRevive1; // Timer para reviver
    public float TimerRevive2;
    public float TimerRevive3;
    public float TimerRevive4;
    public float TimerRevive5;
    public float TimerRevive6;
    public float Revive = 3f; // Tempo para reviver
    public bool isReviving = false; // Indica se o timer de revive já começou



    // Update is called once per frame
    


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        revive();
       
    }

    void revive()
    {
        if (isReviving)
        {


            if (!tree1.activeSelf)
            {
                TimerRevive1 += Time.deltaTime;
                Debug.Log($"TimerRevive: {TimerRevive1}");
            }


            if (TimerRevive1 >= Revive)
            {
                Debug.Log("Árvore reviveu!");
                tree1.SetActive(true);

                TimerRevive1 = 0; // Reseta o timer
                isReviving = false; // Para o processo de revive
            }

            if (!tree2.activeSelf)
            {
                TimerRevive2 += Time.deltaTime;
                Debug.Log($"TimerRevive: {TimerRevive3}");
            }


            if (TimerRevive2 >= Revive)
            {
                Debug.Log("Árvore reviveu!");
                tree2.SetActive(true); ;

                TimerRevive2 = 0; // Reseta o timer
                isReviving = false; // Para o processo de revive
            }

            if (!tree3.activeSelf)
            {
                TimerRevive3 += Time.deltaTime;
                Debug.Log($"TimerRevive: {TimerRevive3}");
            }


            if (TimerRevive3 >= Revive)
            {
                Debug.Log("Árvore reviveu!");
                tree3.SetActive(true);

                TimerRevive3 = 0; // Reseta o timer
                isReviving = false; // Para o processo de revive
            }

            if (!tree4.activeSelf)
            {
                TimerRevive4 += Time.deltaTime;
                Debug.Log($"TimerRevive: {TimerRevive4}");
            }


            if (TimerRevive4 >= Revive)
            {
                Debug.Log("Árvore reviveu!");
                tree4.SetActive(true);

                TimerRevive4 = 0; // Reseta o timer
                isReviving = false; // Para o processo de revive
            }

            if (!tree5.activeSelf)
            {
                TimerRevive5 += Time.deltaTime;
                Debug.Log($"TimerRevive: {TimerRevive4}");
            }


            if (TimerRevive5 >= Revive)
            {
                Debug.Log("Árvore reviveu!");
                tree5.SetActive(true);

                TimerRevive5 = 0; // Reseta o timer
                isReviving = false; // Para o processo de revive
            }

            if (!tree6.activeSelf)
            {
                TimerRevive6 += Time.deltaTime;
                Debug.Log($"TimerRevive: {TimerRevive4}");
            }


            if (TimerRevive6 >= Revive)
            {
                Debug.Log("Árvore reviveu!");
                tree6.SetActive(true);

                TimerRevive6 = 0; // Reseta o timer
                isReviving = false; // Para o processo de revive
            }
        }
    }

    
}
