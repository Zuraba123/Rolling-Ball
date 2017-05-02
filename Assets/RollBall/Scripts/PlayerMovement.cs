using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody playerbody;
    public float speedmultiplier;
    Vector3 deltaPos;
    void Start()
    {
        deltaPos = Vector3.zero;
    }
    void Update()
    {
        deltaPos.x = Input.GetAxis("Horizontal");
        deltaPos.z = Input.GetAxis("Vertical");
    }
    void FixedUpdate()
    {
        playerbody.AddForce(deltaPos * speedmultiplier);
    }
}