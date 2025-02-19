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
//goblin
        if (timeWave >= 10f && timeWave <= 10.2f )
        {
            var projectile = Instantiate(goblinPrefeab);
            projectile.transform.position = WaveRight.position;
        }
        if (timeWave >= 10f && timeWave <= 10.2f)
        {
            var projectile = Instantiate(goblinPrefeab);
            projectile.transform.position = WaveLeft.position;
        }

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
       


    }



}
