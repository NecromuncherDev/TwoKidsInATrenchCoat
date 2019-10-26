using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaskItem : MonoBehaviour
{
    public string taskText;

    public Collider destination;

    public bool active;

    public event Action thisTaskFinished;

    private void OnTriggerEnter(Collider other)
    {
        if (active && destination == other)
        {
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
