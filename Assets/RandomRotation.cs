using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomRotation : MonoBehaviour {


    private Vector3 rotationAngle;
    public int MinAngle;
    public int MaxAngle;
	// Use this for initialization
	void Start () {

        int ran = Random.Range(MinAngle, MaxAngle);
        rotationAngle = new Vector3(ran, ran, ran);

	}
	
	// Update is called once per frame
	void Update () {
        this.transform.Rotate(rotationAngle * Time.deltaTime);
	}
}
