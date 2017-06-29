using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class BallMovement : MonoBehaviour {

    private Rigidbody rb;
    public int _speed;
    public int _jumpHeight;


    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        rb.AddForce(new Vector3(Input.GetAxis("Horizontal") * _speed, 0, Input.GetAxis("Vertical") * _speed));

        if(Input.GetButtonDown("Jump"))
        {
            Debug.Log("JUMP");
            rb.AddForce(new Vector3(0, _jumpHeight, 0));
        }
	}
}
