using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace VikingCrewTools.UI { 
public class PlayerInteract : PlayerController
{

    public event Action Talk;
    private float _lastThrowTime;
        ScriptedDialogueBehaviour talk;

  

    protected override void FixedUpdate()
    {
        base.FixedUpdate();

        if (Input.GetMouseButtonDown(0))
        {
                FireBeam();
        }

    }

    public void FireBeam()
    {
      

        Debug.Log("Interacting");
        Ray ray = new Ray(Cam.transform.position, Cam.transform.forward);
        RaycastHit hit;

        Debug.DrawRay(ray.origin, ray.origin + (ray.direction * 1000), Color.red, 1);

        if (Physics.Raycast(ray, out hit))
        {
            Debug.Log("Inteacted with: " + hit.transform.name);
                
                hit.transform.gameObject.GetComponent<ScriptedDialogueBehaviour>().Interacted();
        }

    }

        
    }

   
}
