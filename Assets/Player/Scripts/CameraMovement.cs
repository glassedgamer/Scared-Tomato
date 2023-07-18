using UnityEngine;

public class CameraMovement : MonoBehaviour {

    GameObject gameManager;

    [SerializeField] float xClamp = 85f;
    [SerializeField] float sensitivityX = 8f;
    [SerializeField] float sensitivityY = 0.5f;
    float mouseX, mouseY;
    float xRotation = 0f;

    [SerializeField] Transform playerCamera;

    void Start() {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Update() {
        transform.Rotate(Vector3.up, mouseX * Time.deltaTime);

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -xClamp, xClamp);
        Vector3 targetRotation = transform.eulerAngles;
        targetRotation.x = xRotation;
        playerCamera.eulerAngles = targetRotation;
    }

    public void ReceiveInput(Vector2 mouseInput) {
        mouseY = mouseInput.y * sensitivityY;
        mouseX = mouseInput.x * sensitivityX;
    }

}
