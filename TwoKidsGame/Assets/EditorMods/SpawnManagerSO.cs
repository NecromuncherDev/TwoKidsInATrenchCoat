using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/SpawnManagerSO", order = 1)]
public class SpawnManagerSO : ScriptableObject
{
    #region Floor
    public string floorPrefabName;
    public Vector3 roomDimentions;
    public Vector3 roomCenter;
    #endregion

    #region Environment
    public string cameraPrefabName;
    public Vector3 cameraStartingPosition;
    public Vector3 CameraStartingRotation;
    #endregion

    #region Player
    #endregion

    #region Populate
    #endregion
}