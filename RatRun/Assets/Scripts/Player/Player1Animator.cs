using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Animator : MonoBehaviour {
	
	void Update () {
        if (Input.GetKey(KeyCode.A) == true) {
            GetComponent<Animator>().Play("Rat_Left_Anim");
        }
        else if (Input.GetKey(KeyCode.D) == true)
        {
            GetComponent<Animator>().Play("Rat_Right_Anim");
        }
        else if (Input.GetKey(KeyCode.D) == false && Input.GetKeyDown(KeyCode.A) == false)
        {
            GetComponent<Animator>().Play("Rat_Idle_Anim");
        }
    }
}
