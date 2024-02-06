using UnityEngine;

public class DeviceInteraction : MonoBehaviour
{
    public Canvas canvas; // Exposed for Inspector

    private void Start()
    {
        if (canvas != null)
        {
            // Disable the canvas initially
            canvas.enabled = false;
        }
        else
        {
            Debug.LogError("Canvas not assigned!");
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Check if the entering collider is the hand or controller
        if (collision.collider.CompareTag("PlayerHand")) // Adjust the tag based on your setup
        {
            Debug.Log("collided");
            // The device is grabbed, enable the canvas
            if (canvas != null)
            {
                canvas.enabled = true;
            }
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        // Check if the exiting collider is the hand or controller
        if (collision.collider.CompareTag("PlayerHand")) // Adjust the tag based on your setup
        {
            // The device is released, disable the canvas
            if (canvas != null)
            {
                canvas.enabled = false;
            }
        }
    }
}
