using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class WaveController : MonoBehaviour
{
    public float timeWave;
    public float GoblinPart;

    public Transform WaveRight;
    public Transform WaveLeft;
    public GameObject goblinPrefeab;
     public GameObject MagoPrefeab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PartWave();
        timeWave += Time.deltaTime;
    }
    void PartWave()
    {
<<<<<<< HEAD
//goblin
        if (timeWave >= 10f && timeWave <= 10.2f )
=======

        if (timeWave >= 10f && timeWave <= 10.01f )
>>>>>>> 03095ea7e1d6807147ed9ff5b7e6d3979ed59e5b
        {
            var projectile = Instantiate(goblinPrefeab);
            projectile.transform.position = WaveRight.position;
        }
<<<<<<< HEAD
        if (timeWave >= 10f && timeWave <= 10.2f)
=======
        if (timeWave >= 10f && timeWave <= 10.01f)
>>>>>>> 03095ea7e1d6807147ed9ff5b7e6d3979ed59e5b
        {
            var projectile = Instantiate(goblinPrefeab);
            projectile.transform.position = WaveLeft.position;
        }
<<<<<<< HEAD

//mago
        if (timeWave >= 10f && timeWave <= 10.2f )
        {
            var projectile = Instantiate(MagoPrefeab);
            projectile.transform.position = WaveRight.position;
        }
        if (timeWave >= 10f && timeWave <= 10.2f)
        {
            var projectile = Instantiate(MagoPrefeab);
            projectile.transform.position = WaveLeft.position;
        }
=======
>>>>>>> 03095ea7e1d6807147ed9ff5b7e6d3979ed59e5b
       


    }



}
