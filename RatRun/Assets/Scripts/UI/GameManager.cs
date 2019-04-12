using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour {


    private bool mPause = false;
    public GameObject mPauseMenu;

    public AudioClip mSoundClip;
    public AudioSource mAudioSource;


    // public GameObject Player1, Player2;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if(Input.GetButtonDown("Cancel") == true)
        {
            Pause();
        }
    }

    public void Pause()
    {
        mPause = !mPause;

        if(mPause == true)
        {
            mPauseMenu.SetActive(true);
        }
        else
        {
            mPauseMenu.SetActive(false);
        }
    }

    public void Restart()
    {
        mPauseMenu.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void ToMainMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void FinishLine()
    {

    }

    public void SoundOnHover()
    {
        Debug.Log("play_audio");
        mAudioSource.PlayOneShot(mSoundClip);
    }
}
