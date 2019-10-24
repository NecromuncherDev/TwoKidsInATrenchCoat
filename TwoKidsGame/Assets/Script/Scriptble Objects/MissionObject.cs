using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Mission", menuName = "ScriptableObjects/Mission", order = 1)]
public class MissionObject : ScriptableObject
{
    public TaskObject[] taks;

    public int missionID;

    public string MissonText;
}
