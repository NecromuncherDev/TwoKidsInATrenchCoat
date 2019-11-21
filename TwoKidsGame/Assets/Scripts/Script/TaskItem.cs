using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaskItem : MonoBehaviour
{
    public string taskText;

    public Collider destination;

    public bool active;

<<<<<<< HEAD
=======
    public bool Finished = false;

>>>>>>> 0956567d6916818cd2a418fae97af2e830019878
    bool talkTofinish;

    public int ID;

<<<<<<< HEAD
    public event Action thisTaskFinished;
=======
    public event Action thisTaskStarted;

    public event Action thisTaskFinished;
   

>>>>>>> 0956567d6916818cd2a418fae97af2e830019878

    public UI_Maneger UI;

    

    private void OnTriggerEnter(Collider other)
    {
        if (active && destination == other)
        {
            UI.MarkTask(ID);
            active = false;
            Debug.Log(taskText);
            OnThisTaskFinish();
        }
    }

    public void Intercacted()
    {
        if (active)
        {
            UI.MarkTask(ID);
            active = false;
            Debug.Log(taskText);
            OnThisTaskFinish();
<<<<<<< HEAD
=======
            
>>>>>>> 0956567d6916818cd2a418fae97af2e830019878
        }
    }


    private void OnThisTaskFinish()
    {
        if (thisTaskFinished !=null)
        {
<<<<<<< HEAD
            thisTaskFinished();
        }
    }
=======
            Finished = true;
            thisTaskFinished();
        }
    }
    public void OnThisTaskStarted()
    {
        if (thisTaskStarted != null)
        {
            thisTaskStarted();
        }
    }
>>>>>>> 0956567d6916818cd2a418fae97af2e830019878

}
