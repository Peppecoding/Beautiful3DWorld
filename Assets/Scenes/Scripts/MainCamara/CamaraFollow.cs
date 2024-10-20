using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;    // Reference to the player object
    public float distance = 5.0f;   // Distance behind the player
    public float height = 2.0f;     // Height above the player
    public float smoothSpeed = 0.125f;  // Smoothness of camera movement

    void LateUpdate()
    {
        // Set the desired position behind and above the player
        Vector3 desiredPosition = player.position - player.forward * distance + Vector3.up * height;
        
        // Smoothly move the camera to the desired position
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;
        
        // Make the camera look at the player
        transform.LookAt(player);
    }
}
