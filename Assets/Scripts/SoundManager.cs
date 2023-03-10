using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using System;

public class SoundManager : MonoBehaviour
{
	public Sound[] sounds;

	public static SoundManager instance;

    void Start()
    {
	    if (instance == null)
	    {
		    instance = this;
	    }
	    else
	    {
		    Destroy(gameObject);
		    return;
	    }
	    
	    DontDestroyOnLoad(gameObject);
	    
	    foreach (Sound s in sounds)
	    {
		    s.source = gameObject.AddComponent<AudioSource>();
		    s.source.clip = s.clip;

		    s.source.volume = s.volume;
		    //s.source.pitch = s.pitch;
		    s.source.loop = s.loop;
	    }
    }

    public void Play(string name)
    {
	    Sound s = Array.Find(sounds, sound => sound.name == name);

	    //if (s == null)
	    //{
		//    Debug.Log("Sound file not found: " + name);
		//    return;
	    //}
	    
	    s.source.Play();
    }
}
