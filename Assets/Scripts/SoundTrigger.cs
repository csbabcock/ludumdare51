using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("ENTERED TRIGGER");
            FindObjectOfType<AudioManager>().Play("ScarySound");
        }
    }
}
