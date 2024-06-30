using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float rotationSpeed = 100f;
    public Transform cameraTransform;

    void Update()
    {
        // Movimiento
        float moveZ = 0f;

        if (Input.GetKey(KeyCode.W))
        {
            moveZ = 1f;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            moveZ = -1f;
        }

        Vector3 move = transform.forward * moveZ * moveSpeed * Time.deltaTime;
        transform.Translate(move, Space.World);

        // Rotación
        float rotateY = 0f;

        if (Input.GetKey(KeyCode.A))
        {
            rotateY = -1f;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            rotateY = 1f;
        }

        transform.Rotate(0, rotateY * rotationSpeed * Time.deltaTime, 0);

        // Mover la cámara para seguir al jugador
        if (cameraTransform != null)
        {
            cameraTransform.position = transform.position;
            cameraTransform.rotation = transform.rotation;
        }
    }
}
