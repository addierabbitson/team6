using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Animator : MonoBehaviour {
	
	void Update () {
        if (Input.GetKey(KeyCode.LeftArrow) == true) {
            GetComponent<Animator>().Play("Rat_Left_Anim");
        }
        else if (Input.GetKey(KeyCode.RightArrow) == true)
        {
            GetComponent<Animator>().Play("Rat_Right_Anim");
        }
        else if (Input.GetKey(KeyCode.LeftArrow) == false && Input.GetKeyDown(KeyCode.RightArrow) == false)
        {
            GetComponent<Animator>().Play("Rat_Idle_Anim");
        }
    }
}
