using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaskItem : MonoBehaviour
{
    public TaskObject thisTask;

    public event Action thisTaskFinished;

    private void OnTriggerEnter(Collider other)
    {
        if (thisTask.active = true &&  thisTask.destination == other )
        {
            thisTaskFinished();
        }
    }

    private void OnThisTaskFinished()
    {
        if (thisTaskFinished != null)
        {
            thisTaskFinished();
        }
    }
}
