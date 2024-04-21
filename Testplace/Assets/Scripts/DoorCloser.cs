using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DoorCloser : MonoBehaviour
{
    [SerializeField] private Animator myDoor;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && DoorManager.Instance.IsDoorOpen) // Prüft, ob die Tür offen ist
        {
            myDoor.Play("Closedoor", 0, 0.0f);
            DoorManager.Instance.CloseDoor(); // Aktualisiert den Türzustand
        }
    }
}
