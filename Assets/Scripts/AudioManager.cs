/*
 * @author: Argert Boja 
 * @company: ABEnt.
 * @date: 11/01/2019
 * @version: 1.0.0.0
*/
using UnityEngine.Audio;
using System;
using UnityEngine;

public class AudioManager : MonoBehaviour {
    // Array which holds the audios of the game
    public Sound[] sounds;

    // This method initializes all attributes of each object
    private void Awake() {
        foreach( Sound s in sounds) {
            s.source = gameObject.AddComponent <AudioSource>();
            s.source.clip = s.clip;
            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
        }
    }

    // This method is used to play the sound
    public void Play( string name) {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        // Throw warning message if the sound with the name provided is not found
        if (s == null) {
            Debug.LogWarning("The sound: " + name + " was not found!");
        }
        s.source.Play();
    }

}
