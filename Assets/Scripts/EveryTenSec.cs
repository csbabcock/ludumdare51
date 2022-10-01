using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class EveryTenSec : MonoBehaviour
{
    public int randomValue;
    public bool playerAlive = true;

    void Awake()
    {
    }

    void Start()
    {
        StartCoroutine(TenSecTimer());
    }

    void OnDisable()
    {
        StopCoroutine(TenSecTimer());
    }

    IEnumerator TenSecTimer(float countTime = 10f)
    {
        while (playerAlive)
        {
            Debug.Log(Time.time);
            randomValue = Random.Range(1, 4);
            yield return new WaitForSeconds(countTime);
            RandomEvent();
        }
    }
    
    void RandomEvent()
    {
        switch (randomValue)
        {
            case 1:
                Debug.Log("Enemy is moving closer");
                break;
            case 2:
                Debug.Log("Object Broke");
                break;
            case 3:
                Debug.Log("Somethings changed");
                break;
            case 4:
                Debug.Log("I heard something");
                break;
            default:
                Debug.Log("Incorrect random value.");
                break;
        }
    }
}
