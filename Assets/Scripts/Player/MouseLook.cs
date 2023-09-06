using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public float mouseSensitivity = 30f;
    public Transform playerModel, playerCamera;

    Vector2 mousePosition;
    float mouseX, mouseY, xRotation = 0f, xClamp = 90f;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
    public void Update()
    {
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -xClamp, xClamp);
        Vector3 targetRotation = transform.eulerAngles;
        targetRotation.x = xRotation;
        playerModel.Rotate(Vector3.up * mouseX);
        playerCamera.eulerAngles = targetRotation;
    }
    public void ReceiveInput(Vector2 _mousePosition)
    {
        mousePosition = _mousePosition;
        mouseX = mousePosition.x * mouseSensitivity * Time.deltaTime;
        mouseY = mousePosition.y * mouseSensitivity * Time.deltaTime;
    }
}
