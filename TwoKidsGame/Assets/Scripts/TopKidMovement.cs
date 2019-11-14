using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopKidMovement : MonoBehaviour
{
    [SerializeField]
    private float maxTilt = 20f;

    private void Start()
    {
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.I) && transform.rotation.x < maxTilt)
        {
            transform.RotateAround(transform.right, 1f * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.K) && transform.rotation.x > -maxTilt)
        {
            transform.RotateAround(transform.right, -1f * Time.deltaTime);
        }

    }

}
