using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random=UnityEngine.Random;

public class EveryTenSeconds : MonoBehaviour
{
    public int randomValue = 0;
    private int tempValue = 0;
    public bool playerAlive = true;

    public FollowPlayer followPlayer;
    public MoveObject moveObject;
    public ChangeObject changeObject;
    public PlaySound playSound;

    void Start()
    {
        StartCoroutine(TenSecondTimer());
    }

    void OnDisable()
    {
        StopCoroutine(TenSecondTimer());
    }

    IEnumerator TenSecondTimer(float countTime = 10f)
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

        if (tempValue == randomValue && randomValue < 4)
        {
            randomValue = 4;
        }

        switch (randomValue)
        {
            case 1:
                Debug.Log("Enemy is moving closer");
                followPlayer.Follow();
                tempValue = randomValue;
                break;
            case 2:
                Debug.Log("Object Broke");
                moveObject.moveObject = true;
                tempValue = randomValue;
                break;
            case 3:
                Debug.Log("Somethings changed");
                changeObject.ChangePosition();
                tempValue = randomValue;
                break;
            case 4:
                Debug.Log("I heard something");
                playSound.SoundFX();
                tempValue = randomValue;
                break;
            default:
                Debug.Log("Incorrect random value.");
                break;
        }
    }
}
