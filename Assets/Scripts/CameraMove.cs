using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public float sensitivity = 200f; // Adjust in the Inspector to control speed
    public float verticalLookLimit = 80f; // Limits how far up/down the camera can look

    private float rotationX = 0f;
    private float rotationY = 0f;

    void Start()
    {
        // Lock the cursor to the center of the screen and hide it
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        // Get mouse input axes
        float mouseX = Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime;

        // Apply horizontal rotation to the parent object (the player)
        // 'transform.Rotate' uses the object's local axes by default
        transform.parent.Rotate(Vector3.up * mouseX);

        // Calculate vertical rotation for the camera
        rotationX -= mouseY;
        // Clamp the vertical rotation to prevent flipping over
        rotationX = Mathf.Clamp(rotationX, -verticalLookLimit, verticalLookLimit);

        // Apply the clamped vertical rotation to the camera itself
        // We use 'localRotation' because the camera is a child of the player
        transform.localRotation = Quaternion.Euler(rotationX, 0f, 0f);
    }
}