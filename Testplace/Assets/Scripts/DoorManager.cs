using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DoorManager : MonoBehaviour
{
    public static DoorManager Instance; // Singleton-Instanz

    public bool IsDoorOpen { get; private set; } = false; // Zustand der Tür

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // Verhindert das Zerstören bei Szenenwechsel
        }
        else
        {
            Destroy(gameObject); // Zerstört überflüssige Instanzen
        }
    }

    public void OpenDoor()
    {
        IsDoorOpen = true;
    }

    public void CloseDoor()
    {
        IsDoorOpen = false;
    }
}