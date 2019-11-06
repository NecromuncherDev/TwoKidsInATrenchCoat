using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private HingeJoint hj;
    public Transform myAnim;
    public bool mirror;

    private void Start()
    {
        hj = GetComponent<HingeJoint>();
    }

    private void Update()
    {
        if (myAnim != null)
        {
            JointSpring js = hj.spring;
            js.targetPosition = myAnim.localEulerAngles.x;
            if (js.targetPosition > 180)
            {
                js.targetPosition -= 360;
            }

            js.targetPosition = Mathf.Clamp(js.targetPosition, hj.limits.min +5, hj.limits.max -5);

            if (mirror)
            {
                js.targetPosition *= -1;
            }
            hj.spring = js;
        }
    }
}
