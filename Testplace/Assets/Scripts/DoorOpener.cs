using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DoorOpener : MonoBehaviour
{
    [SerializeField] private Animator myDoor;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !DoorManager.Instance.IsDoorOpen) // Prüft, ob die Tür geschlossen ist
        {
            myDoor.Play("Opendoor", 0, 0.0f);
            DoorManager.Instance.OpenDoor(); // Aktualisiert den Türzustand
        }
    }
}
