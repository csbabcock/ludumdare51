using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random=UnityEngine.Random;


public class MoveObject : MonoBehaviour
{
    [SerializeField] Rigidbody[] rb;
    public bool moveObject;

    [SerializeField] float randomX = 0;
    [SerializeField] float randomY = 0;
    [SerializeField] float randomZ = 0;

    void Update()
    {
        if (moveObject)
        {
            randomX = Random.Range(0.1f, 1f);
            randomY = Random.Range(0.1f, 1f);
            randomZ = Random.Range(0.1f, 1f);

            rb[Random.Range(0,3)].AddForce(randomX,randomY,randomZ, ForceMode.Impulse);
            
            moveObject = false;
        }
    }
}
