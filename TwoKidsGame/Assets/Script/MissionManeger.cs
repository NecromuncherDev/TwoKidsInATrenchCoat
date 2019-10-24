using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissionManeger : MonoBehaviour
{
    public MissionObject [] missions;
   

    private int currentMissionID;
    private int currentTaskID;

    private TaskItem anyTask;

    public static event Action missionFinished;

    private void Start()
    {
        
        anyTask.thisTaskFinished += AnyTaskFinished;
        missionFinished += StartNextMission;
        currentMissionID = 0;
       

}

    private void onMissionFinished()
    {
        if (missionFinished != null)
        {
            missionFinished();
        }
    }

  // when task finished this func is called to check if all tasks in missions have ended 
    private void AnyTaskFinished()
    {
        anyTask.thisTask.finished = true;

        // if we want to add an animation or event when task is finished put it here

        foreach(TaskObject task in missions[currentMissionID].taks)
        {
            if (!task.finished)
            {
                break;
            }
            else
            {
                missionFinished();
            }
        }

    }

    private void StartNextMission()
    {
        currentMissionID ++;
        // here we will put the visual effect of starting a new mission, changing the to do list on the side and so forth
    }

}
