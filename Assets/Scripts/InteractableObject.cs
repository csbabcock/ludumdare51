using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableObject : MonoBehaviour
{
    public Transform PlayerCamera;
    [Header("Interaction Distance")]
    public float MaxDistance = 10;
    public  Animator anim;
      
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Pressed();
        }
    }
      
    void Pressed()
    {
        //This will name the Raycasthit information of which object the raycast hit.
        RaycastHit hit;
      
        if (Physics.Raycast(PlayerCamera.transform.position, PlayerCamera.transform.forward, out hit, MaxDistance))
        {
            Vector3 forward = transform.TransformDirection(Vector3.forward) * 10;
            Debug.DrawRay(transform.position, forward, Color.green);
            
            // if raycast hits, then it checks if it hit an object with the tag Interactable.
            if (hit.transform.tag == "Interactable")
            {
                //This line will get the Animator from  Parent that was hit by the raycast.
                anim = hit.transform.GetComponentInParent<Animator>();

                #region Doors

                if (!anim.GetBool("isOpen"))
                {
                    //This line will set the bool true so it will play the animation.
                    anim.SetBool("isOpen", true);
                }

                else
                {
                    anim.SetBool("isOpen", false);
                }

                #endregion
                
            }
        }
    }
}
