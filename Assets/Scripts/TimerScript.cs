using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerScript : MonoBehaviour
{
    [SerializeField]
    int timer = 10;
    public bool loopTimer;


    public void StartTimer()
    {
        Debug.Log("Starting countdown...");
        StartCoroutine(SecondTimer());
    }

    IEnumerator SecondTimer()
    {
        yield return new WaitForSeconds(timer);
        EndTimer();
    }

    void EndTimer()
    {
        if (loopTimer)
            StartTimer();
        else
            Debug.Log("Ending");
    }
}
