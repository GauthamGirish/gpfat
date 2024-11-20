using UnityEngine;

public class DoorController : MonoBehaviour
{
    public Transform door;
    public float openAngle = 90f; // Angle to open the door
    public float speed = 2f; // Speed of the door opening
    public KeyCode openKey = KeyCode.E;

    private bool isOpen = false;
    private Quaternion closedRotation;
    private Quaternion openRotation;

    void Start()
    {
        // Store the initial rotation of the door
        closedRotation = door.rotation;
        openRotation = closedRotation * Quaternion.Euler(0, openAngle, 0);
    }

    void Update()
    {
        if (Input.GetKeyDown(openKey))
        {
            isOpen = !isOpen; // Toggle door state
        }

        // Smoothly rotate the door to the target rotation
        door.rotation = Quaternion.Slerp(door.rotation, isOpen ? openRotation : closedRotation, Time.deltaTime * speed);
    }
}
