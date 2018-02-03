using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudController : MonoBehaviour {

    //smallest size
    private float minimum = 1.0f;

    //scale changing speed
    private float magSpeed = 10.0f;

    //広大率
    private float magnification = 0.07f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //雲の広大縮小
        this.transform.localScale = new Vector3(this.minimum + Mathf.Sin(Time.time * this.magSpeed) * this.magnification, this.transform.localScale.y, this.minimum + Mathf.Sin(Time.time * this.magSpeed) * this.magnification);

	}
}
