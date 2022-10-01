using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

[System.Serializable]
public class Sound
{
    public string name;
    
    public AudioClip clip;
    
    [Range(0f, 1f)]
    public float volume;
    [Range(0.1f, 3.0f)]
    public float pitch;

    [Range(0f, 1f)] 
    public float spatialBlend;

    public float minDistance;
    public float maxDistance;

    [HideInInspector]
    public AudioSource source;

}
