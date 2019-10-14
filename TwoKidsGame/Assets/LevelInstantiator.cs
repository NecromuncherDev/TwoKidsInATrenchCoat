/// Project:        Two Kids In A Trench Coat - Game
/// Authors:        Oded Nachshon
/// Script:         LevelInstantiator
/// Description:    This Script sould load information from
///                 a pre-specified configuration and load
///                 the level accordingly.

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelInstantiator : MonoBehaviour
{
    [SerializeField]
    private SpawnManagerSO levelConf;

    // Create the level
    void Start()
    {
        if (levelConf == null)
        {
            throw new Exception("No level configuration defined for this level. Dumbasses.");
            /// Further down the line we want that
            /// handling a "no level conf exception"
            /// would be loading some default config
            /// instead of just popping out an error message
        }
        else
        {
            CreateFloor();
            CreateEnvironment();
            SpawnPlayers();
            PopulateRoom();
        }
    }

    // Get and intitialize the floor this level according to the level config
    private void CreateFloor()
    {
        UnityEngine.Object pPrefab = Resources.Load("Prefabs/" + levelConf.floorPrefabName);
        GameObject pNewObject = (GameObject)GameObject.Instantiate(pPrefab, levelConf.roomCenter, Quaternion.identity);
        pNewObject.transform.localScale = levelConf.roomDimentions;
    }

    private void CreateEnvironment()
    {
        Debug.LogWarning("Not implemented");
    }

    private void SpawnPlayers()
    {
        Debug.LogWarning("Not implemented");
    }

    private void PopulateRoom()
    {
        Debug.LogWarning("Not implemented");
    }
}