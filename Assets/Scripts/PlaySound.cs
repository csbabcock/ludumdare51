using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySound : MonoBehaviour
{
    public AudioSource source;
    public AudioClip clip;

    public Interact interact;

    public void SoundFX()
    {
        if (!interact.isOpen)
        {
            source.PlayOneShot(clip);
        }
    }
}
