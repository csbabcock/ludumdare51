using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random=UnityEngine.Random;


public class MoveObject : MonoBehaviour
{
    [SerializeField] Rigidbody[] rb;
    public bool moveObject;

    float randomX = 0;
    float randomY = 0;
    float randomZ = 0;

    void Update()
    {
        if (moveObject)
        {
            randomX = Random.Range(1f, 3f);
            randomY = Random.Range(1f, 3f);
            randomZ = Random.Range(1f, 3f);

            rb[Random.Range(0,3)].AddForce(randomX,randomY,randomZ, ForceMode.Impulse);
            
            moveObject = false;
        }
    }
}
