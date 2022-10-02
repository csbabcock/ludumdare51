using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySound : MonoBehaviour
{
    public AudioSource source;
    public AudioClip clip;

    public void SoundFX()
    {
        source.PlayOneShot(clip);
    }
}
