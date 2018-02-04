using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallScore : MonoBehaviour {

    //reset Score
    private int Score = 0;

    //Small Star Score
    private int SmallStarScore = 10;

    //Small Cloud Score
    private int SmallCloudScore = 20;

    //Large Star Score
    private int LargeStarScore = 30;

    //Large Cloud Score
    private int LargeCloudScore = 40;

    //Display score
    private GameObject scoreText;

    // Use this for initialization
    void Start () {
        //get ScoreText Object
        this.scoreText = GameObject.Find("ScoreText");
    }
	
	// Update is called once per frame
	void Update () {
        //show score
        this.scoreText.GetComponent<Text>().text = "Score:" + Score.ToString();
    }

    //if the ball collide other object, get score
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("SmallStarTag"))
        {
            Score += SmallStarScore;
        }
        else if (other.gameObject.CompareTag("SmallCloudTag"))
        {
            Score += SmallCloudScore;
        }
        else if (other.gameObject.CompareTag("LargeStarTag"))
        {
            Score += LargeStarScore;
        }
        else if (other.gameObject.CompareTag("LargeCloudTag"))
        {
            Score += LargeCloudScore;
        }
        Debug.Log(Score);

        
    }
    
}
