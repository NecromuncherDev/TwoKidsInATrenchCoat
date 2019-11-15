using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public MissionManeger[] missions;
    private int activeMission;

    private void Start()
    {
        activeMission = 0;
        missions[activeMission].active();
        MissionManeger.MissionDone += NextMission;
    }
    public void NextMission()
    {
        activeMission++;
        if (missions.Length > activeMission)
        {
            missions[activeMission].active();
        }
        else
        {
            Debug.Log("game done");
        }
        
    }
}
