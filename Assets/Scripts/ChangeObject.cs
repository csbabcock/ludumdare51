using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeObject : MonoBehaviour
{
    public GameObject[] changeableObjects;
    public Vector3 tempPosition;

    public void ChangePosition()
    {
        tempPosition = changeableObjects[0].transform.position;
        
        changeableObjects[0].transform.position = changeableObjects[1].transform.position;

        changeableObjects[1].transform.position = tempPosition;
    }
}
