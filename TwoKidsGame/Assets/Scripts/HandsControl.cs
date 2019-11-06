using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandsControl : MonoBehaviour
{
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddForceAtPosition((Vector3.right + Vector3.up) * 0.5f, this.transform.position, ForceMode.Impulse);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForceAtPosition((Vector3.left + Vector3.down) * 0.5f, this.transform.position, ForceMode.Impulse);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rb.AddForceAtPosition(Vector3.forward, this.transform.position, ForceMode.Impulse);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            rb.AddForceAtPosition(Vector3.back, this.transform.position, ForceMode.Impulse);
        }
    }
}
