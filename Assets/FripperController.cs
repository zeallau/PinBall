using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FripperController : MonoBehaviour {

    //add HingeJoint component
    private HingeJoint myHingeJoint;

    //reset
    private float defaultAngle = 20;
    //flick angle
    private float flickAngle = -20;

	// Use this for initialization
	void Start () {
        //Get HingeJoint component
        this.myHingeJoint = GetComponent<HingeJoint>();

        //Get flick angle
        SetAngle(this.defaultAngle);
	}
	
	// Update is called once per frame
	void Update () {
		//press left arrow button to move left fripper
        if(Input.GetKeyDown(KeyCode.LeftArrow) && tag == "LeftFripperTag")
        {
            SetAngle(this.flickAngle);
        }
        //press right arrow button to move right fripper
        if (Input.GetKeyDown(KeyCode.RightArrow) && tag == "RightFripperTag")
        {
            SetAngle(this.flickAngle);
        }

        //Fripper back when release button
        if(Input.GetKeyUp(KeyCode.LeftArrow) && tag == "LeftFripperTag")
        {
            SetAngle(this.defaultAngle);
        }
        if (Input.GetKeyUp(KeyCode.RightArrow) && tag == "RightFripperTag")
        {
            SetAngle(this.defaultAngle);
        }
    }

    //fripper angle setting
    public void SetAngle(float angle) {
        JointSpring jointSpr = this.myHingeJoint.spring;
        jointSpr.targetPosition = angle;
        this.myHingeJoint.spring = jointSpr;
    }
}
