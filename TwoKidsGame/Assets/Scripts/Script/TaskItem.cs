using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaskItem : MonoBehaviour
{
    public string taskText;

    public Collider destination;

    public bool active;

    bool talkTofinish;

    public int ID;

    public event Action thisTaskFinished;

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
        }
    }


    private void OnThisTaskFinish()
    {
        if (thisTaskFinished !=null)
        {
            thisTaskFinished();
        }
    }

}
