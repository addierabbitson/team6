using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class Menus : MonoBehaviour
{

    public AudioClip mSoundClip;
    public AudioSource mAudioSource;

	// Use this for initialization
	void Start ()
    {
        mAudioSource = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    public void Play()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void SoundOnHover()
    {
        Debug.Log("play_audio");
        mAudioSource.PlayOneShot(mSoundClip);
    }
}
