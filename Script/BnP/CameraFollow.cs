using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform Ball;
    private Vector3 offset;
    void Start()
    {
        offset = transform.position - Ball.position;
    }

    void LateUpdate()
    {
        transform.position = Ball.position + offset;
    }
}