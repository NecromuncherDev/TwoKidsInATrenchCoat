using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottomKidMovement : MonoBehaviour
{
    private Rigidbody rigidbody;
    [SerializeField]
    private float rotationMultiplier;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0, 0, Input.GetAxis("Vertical")) * Time.deltaTime);
        transform.RotateAroundLocal(transform.up, Input.GetAxis("Horizontal") * Time.deltaTime * rotationMultiplier);
    }
}
