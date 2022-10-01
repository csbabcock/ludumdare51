using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FollowPlayer : MonoBehaviour
{
    public Transform target;
    NavMeshAgent nav;

    public EveryTenSec everyTenSec;

    // Start is called before the first frame update
    void Start()
    {
        nav = GetComponent<NavMeshAgent>();
    }
    public void Follow()
    {
        if (everyTenSec.randomValue == 1)
        {
            nav.SetDestination(target.position);
        }
    }
}
