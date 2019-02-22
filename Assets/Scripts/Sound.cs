/*
 * @author: Argert Boja 
 * @company: ABEnt.
 * @date: 11/01/2019
 * @version: 1.0.0.0
*/
using UnityEngine.Audio;
using UnityEngine;

// System.Serializable is used whenever we want the class to show in inspector
[System.Serializable]
public class Sound {
    // Audio source name
    public string name;
    // Audio clip
    public AudioClip clip;
    // Volume with a range bar
    [Range(0f, 1f)]
    public float volume;
    // Pitch with a range bar
    [Range(0f, 5f)]
    public float pitch;
    // Audio source which is not shown in inspector even though is public
    [HideInInspector]
    public AudioSource source;
}
