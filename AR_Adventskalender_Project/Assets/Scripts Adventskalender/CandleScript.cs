using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandleScript : MonoBehaviour
{
    // Start is called before the first frame update
    public ParticleSystem fire;
    public bool flameIsOn = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ParticleSystem.SizeOverLifetimeModule a = fire.sizeOverLifetime;
        Debug.Log(a.x.curveMax);
    }

    private void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            /*if (flameIsOn)
            {
                var ps = fire.main;
                ps.startLifetime = 0;
            } else
            {
                var ps = fire.main;
                ps.startLifetime = 5;
                

            }*/
            ParticleSystem.EmissionModule emissionFire = fire.emission;
            if (emissionFire.enabled)
            {
                emissionFire.enabled = false;
            } else
            {
                emissionFire.enabled = true;
            }

        }
    }
}
