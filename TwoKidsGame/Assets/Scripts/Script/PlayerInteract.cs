using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace VikingCrewTools.UI { 
public class PlayerInteract : MonoBehaviour
{

<<<<<<< HEAD
    public event Action Talk;
    private float _lastThrowTime;
        ScriptedDialogueBehaviour talk;
        public GameObject head;
=======
   
    public GameObject head;
>>>>>>> 0956567d6916818cd2a418fae97af2e830019878



        private void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                FireBeam();
            }
        }
 

    public void FireBeam()
    {
      

        Debug.Log("Interacting");
        Ray ray = new Ray(head.transform.position, head.transform.forward);
        RaycastHit hit;

        Debug.DrawRay(ray.origin, ray.origin + (ray.direction * 1000), Color.red, 1);

        if (Physics.Raycast(ray, out hit))
        {
            Debug.Log("Inteacted with: " + hit.transform.name);
<<<<<<< HEAD

                if (hit.transform.gameObject.GetComponent<ScriptedDialogueBehaviour>() != null)
                {
                    hit.transform.gameObject.GetComponent<ScriptedDialogueBehaviour>().Interacted();
                }
=======
                TaskItem hitTask = hit.transform.gameObject.GetComponent<TaskItem>();
                ScriptedDialogueBehaviour talkScript = hit.transform.gameObject.GetComponent<ScriptedDialogueBehaviour>();

                    if (hit.transform.gameObject.GetComponent<ScriptedDialogueBehaviour>() != null)
                {
                    hit.transform.gameObject.GetComponent<ScriptedDialogueBehaviour>().ChooseScript();
                }

>>>>>>> 0956567d6916818cd2a418fae97af2e830019878
                if (hit.transform.gameObject.GetComponent<TaskItem>() != null)
                {
                    hit.transform.gameObject.GetComponent<TaskItem>().Intercacted();
                }
<<<<<<< HEAD
=======
                
               
>>>>>>> 0956567d6916818cd2a418fae97af2e830019878


        }

    }

        
    }

   
}
