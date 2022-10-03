using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FollowPlayer : MonoBehaviour
{
    public Transform target;
    NavMeshAgent nav;

    public EveryTenSeconds everyTenSeconds;

    // Start is called before the first frame update
    void Start()
    {
        nav = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        Follow();
    }

    public void Follow()
    {
        if (everyTenSeconds.randomValue == 1)
        {
            nav.SetDestination(target.position);
        }
    }
}
