using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cammovement : MonoBehaviour
{
    public GameObject Player;
    public float rotationSpeed = 20.0f; // Geschwindigkeit der Kamerarotation

    private Vector3 offset;
    private float currentAngle = 0.0f; // Aktueller Winkel der Kamera um den Spieler

    private void Start()
    {
        offset = transform.position - Player.transform.position;
    }

    void LateUpdate()
    {
        // Rotation mit den Tasten Q und E
        if (Input.GetKey(KeyCode.Q))
        {
            currentAngle -= rotationSpeed * Time.deltaTime; // Linksdrehung
        }
        else if (Input.GetKey(KeyCode.E))
        {
            currentAngle += rotationSpeed * Time.deltaTime; // Rechtsdrehung
        }

        // Aktualisiere die Position der Kamera basierend auf dem aktuellen Winkel
        Quaternion rotation = Quaternion.Euler(0, currentAngle, 0);
        transform.position = Player.transform.position + rotation * offset;

        // Stelle sicher, dass die Kamera weiterhin auf den Spieler gerichtet ist
        transform.LookAt(Player.transform.position);
    }
}