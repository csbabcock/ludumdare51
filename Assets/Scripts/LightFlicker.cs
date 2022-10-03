using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random=UnityEngine.Random;

public class LightFlicker : MonoBehaviour
{
    public Light lightType;

    public AudioSource lightSound;

    public float minTime;

    public float maxTime;

    public float flickerTimer;
    // Start is called before the first frame update
    void Start()
    {
        flickerTimer = Random.Range(minTime, maxTime);
    }

    // Update is called once per frame
    void Update()
    {
        LightsFlickering();
    }

    void LightsFlickering()
    {
        if (flickerTimer > 0 )
        {
            flickerTimer -= Time.deltaTime;
        }

        if (flickerTimer <= 0)
        {
            lightType.enabled = !lightType.enabled;
            flickerTimer = Random.Range(minTime, maxTime);
            lightSound.Play();
        }
    }
}
