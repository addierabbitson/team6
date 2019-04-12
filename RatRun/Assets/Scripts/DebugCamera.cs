using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugCamera : MonoBehaviour {

    public GameObject player1;
    public GameObject player2;
    public GameObject inFront;
    public GameObject debugCamera;
    public float midpoint;
    public float Difference;
	// Use this for initialization
	void Start () {
        player1 = GameObject.FindGameObjectWithTag("Player1");
        player2 = GameObject.FindGameObjectWithTag("Player2");
	}
	
	// Update is called once per frame
	void Update () {

        

        if (player1.transform.position.x > player2.transform.position.x)
        {
            Difference = player1.transform.position.z;
            inFront = player1;
            midpoint = -Difference;
        }
        else 
        {

            Difference = player2.transform.position.z;
            inFront = player2;
            midpoint = -Difference;
        }
        
        transform.position = inFront.transform.position + new Vector3(0, 10, midpoint);
        
	}
}
