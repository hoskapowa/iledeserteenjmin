using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    void FixedUpdate()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        if (rb != null)
        {
            if (Input.GetButton("Fire1"))
            {
                rb.AddForce(transform.right * 30);
                //transform.TransformDirection(dir); (astuce de simon)
            }
            Animator anim = GetComponent<Animator>();
            if (anim != null)
            {
                anim.SetFloat("Speed", rb.velocity.magnitude);
            }
            Rigidbody tq = GetComponent<Rigidbody>();
            if (tq != null)
            {
                if (Input.GetButton("Fire2"))
                {
                    tq.AddTorque(transform.up * 50);
                }
            }
        }
    }

}