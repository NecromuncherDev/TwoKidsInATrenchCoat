using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System;

public class UI_Maneger : MonoBehaviour
{
    public MissionManeger[] missions;
   
    [SerializeField]
    private TextMeshProUGUI missionText;
    [SerializeField]
    private TextMeshProUGUI taskText;
    private int activeMission;

    private void Start()
    {
        activeMission = 0;
        MissionManeger.MissionDone += NextMission;
      
        missionText.text = missions[activeMission].missionText;
        foreach (TaskItem task in missions[activeMission].tasks)
        {
            taskText.text += task.taskText + Environment.NewLine;
        }

    }

    public void NextMission ()
    {
        activeMission++;
        taskText.text = "";
        if (activeMission >= missions.Length)
            return;
        else
        {
            missionText.text = missions[activeMission].missionText;
            foreach (TaskItem task in missions[activeMission].tasks)
            {
                taskText.text += task.taskText + Environment.NewLine;
            }
        }
    }

    public void MarkTask (int id)
    {
        taskText.text = "";
        foreach (TaskItem task in missions[activeMission].tasks)
        {
            if (task.ID == id)
            taskText.text += task.taskText + " Finished" + Environment.NewLine;
            else
            taskText.text += task.taskText + Environment.NewLine;
        }
    }



}
