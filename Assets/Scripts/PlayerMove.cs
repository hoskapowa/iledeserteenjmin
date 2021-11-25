using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        RigibBody rb;
        rb = GetComponent<RigidBody>();

        float vert = input.GetAxis("Vertical");
        float hort = input.GetAxis("Horizontal");

        rb.AddForce(vert * transform.forward * 30);
        rb.AddForce(hort * transform.right * 30);

    }
}
