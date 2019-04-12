using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    // Use this for initialization
    
    public float horizontal;
    public Vector3 moveForward;
    public float speed;

    public bool isPlayer2;
    public Rigidbody m_rigidBody;
    public float cooldownTimer;
    public float slowdownSpeed;
   
    void Start()
    {
        m_rigidBody = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update () {

        if (!isPlayer2)
        {
            if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.D) && cooldownTimer >= 0)
            {

                cooldownTimer = 10f;

                if (horizontal >= 0 && horizontal <= 5)
                {
                    horizontal += 0.5f;
                }
                if (horizontal >= 5 && horizontal <= 10)
                {
                    horizontal += 0.25f;
                }
                if (horizontal >= 10f)
                {
                    horizontal = 10f;
                }
                moveForward = new Vector3(horizontal, 0, 0);
                m_rigidBody.AddForce(moveForward * speed, ForceMode.Impulse);

                
                //remmber the shit you did 2 months ago with force and velocity

            }
            else if (!Input.GetKeyDown(KeyCode.A) && !Input.GetKeyDown(KeyCode.D))
            {
                cooldownTimer -= 0.5f;
                if (cooldownTimer <= 0)
                {
                    cooldownTimer = 0;
                }
                if (cooldownTimer == 0)
                {
                    if (horizontal <= 10 && horizontal >= 5)
                    {
                        horizontal -= 0.5f;
                    }
                    if (horizontal >= 0 && horizontal <= 5)
                    {
                        horizontal -= 20.0f;
                    }
                    if (horizontal <= 0f)
                    {
                        horizontal = 0;
                        moveForward = new Vector3(horizontal, 0, 0);
                        m_rigidBody.AddForce(moveForward * slowdownSpeed, ForceMode.Impulse);
                    }
                    
                    m_rigidBody.AddForce(moveForward * speed, ForceMode.Impulse);


                }
            }

        }

        if (isPlayer2)
        {
            if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.RightArrow) && cooldownTimer >= 0)
            {

                cooldownTimer = 10f;

                if (horizontal >= 0 && horizontal <= 5)
                {
                    horizontal += 0.5f;
                }
                if (horizontal >= 5 && horizontal <= 10)
                {
                    horizontal += 0.25f;
                }
                if (horizontal >= 10f)
                {
                    horizontal = 10f;
                }
                moveForward = new Vector3(horizontal, 0, 0);
                m_rigidBody.AddForce(moveForward * speed, ForceMode.Impulse);


                //remmber the shit you did 2 months ago with force and velocity

            }
            else if (!Input.GetKeyDown(KeyCode.LeftArrow) && !Input.GetKeyDown(KeyCode.RightArrow))
            {
                cooldownTimer -= 0.5f;
                if (cooldownTimer <= 0)
                {
                    cooldownTimer = 0;
                }
                if (cooldownTimer == 0)
                {
                    if (horizontal <= 10 && horizontal >= 5)
                    {
                        horizontal -= 0.5f;
                    }
                    if (horizontal >= 0 && horizontal <= 5)
                    {
                        horizontal -= 20.0f;
                    }
                    if (horizontal <= 0f)
                    {
                        horizontal = 0;
                        moveForward = new Vector3(horizontal, 0, 0);
                        m_rigidBody.AddForce(moveForward * slowdownSpeed, ForceMode.Impulse);
                    }

                    m_rigidBody.AddForce(moveForward * speed, ForceMode.Impulse);

                }
            }
        }
      
	}
}
