using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TriggerDoorController1 : MonoBehaviour
{
    [SerializeField] private Animator myDoor = null;
    [SerializeField] private bool openTrigger = false;
    [SerializeField] private bool closeTrigger = false;
    private bool aaa = false;

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.CompareTag("Player"))
        {
            
            if (openTrigger)
            {
                if(aaa == false)
                {
                    myDoor.Play("Opendoor",0,0.0f);
                    aaa = true;
                }
                
            }
            else if (closeTrigger)
            {
                if(aaa)
                {
                    myDoor.Play("Closedoor", 0, 0.0f);
                    aaa = false;
                }
            }
        }
    }
}
