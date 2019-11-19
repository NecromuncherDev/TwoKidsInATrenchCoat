using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopKidMovement : MonoBehaviour
{
    private Rigidbody rigidbody;
    private HingeJoint hj;

    private void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        hj = GetComponent<HingeJoint>();
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(rigidbody.GetPointVelocity(Vector3.zero));
    }

}
