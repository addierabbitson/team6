using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EndGame : MonoBehaviour {

    public GameObject EndGameScreen;
    GameObject Player1, Player2;
    public Text winTextbox;

	// Use this for initialization
	void Start () {
        Player1 = GameObject.FindGameObjectWithTag("Player1");
        Player2 = GameObject.FindGameObjectWithTag("Player2");
	}
	
	// Update is called once per frame
	void Update () {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("collided");

        Finish();
    }

    void Finish()
    {
        EndGameScreen.SetActive(true);
        if(Player1.transform.position.z > Player2.transform.position.z)
        {
            winTextbox.GetComponent<Text>().text = "Player 1 Wins";
        }
        else
        {
            winTextbox.GetComponent<Text>().text = "Player 2 Wins";
        }
    }

    public void ToMainMenu()
    {
        EndGameScreen.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void replay()
    {
        EndGameScreen.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
