using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random=UnityEngine.Random;

public class EveryTenSec : MonoBehaviour
{
    public int randomValue = 0;
    public bool playerAlive = true;

    public FollowPlayer followPlayer;
    public MoveObject moveObject;

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
            yield return new WaitForSeconds(countTime);
            RandomEvent();
        }
    }
    
    void RandomEvent()
    {
        randomValue = Random.Range(1, 4);

        switch (randomValue)
        {
            case 1:
                Debug.Log("Enemy is moving closer");
                followPlayer.Follow();
                break;
            case 2:
                Debug.Log("Object Broke");
                moveObject.moveObject = true;
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
