using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarController : MonoBehaviour {

    //rotate speed
    private float rotSpeed = 1.0f;

	// Use this for initialization
	void Start () {
        //Setup rotation start angle
        this.transform.Rotate(0, Random.Range(0, 360), 0);

	}
	
	// Update is called once per frame
	void Update () {
        //rotation
        this.transform.Rotate(0, this.rotSpeed, 0);
		
	}
}
