using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Behavior1 : MonoBehaviour
{
    private Rigidbody rb;
    public float jumpForce = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        JumpFunction();
    }

    void JumpFunction (){

        Debug.Log("Jumps");
        rb.AddForce(Vector3.up * jumpForce);
    }
}


