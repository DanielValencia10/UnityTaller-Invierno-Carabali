using UnityEngine;

// Hace girar el pivote de las sirenas. Red_Light y Blue_Light son hijas
// de este objeto, así que giran con él (transformación relativa).
public class SirenRotation : MonoBehaviour
{
    [Tooltip("Velocidad de giro en grados por segundo")]
    public float rotationSpeed = 270f;

    void Update()
    {
        // Gira alrededor del eje Y local (vertical), como una sirena real
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime, Space.Self);
    }
}