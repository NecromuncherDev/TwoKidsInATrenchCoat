using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "BasicTask", menuName = "ScriptableObjects/BasicTask", order = 2)]
public class TaskObject : ScriptableObject
{
    //task are the indeviduals parts of a bigger mission, for making popcorn the tesks will be, get the butter, get corn, activte machine.
    public GameObject item2get;

    public Collider destination;

    public int taskID;

    public string taskText;

    public bool active;
    public bool finished;
}
