using UnityEngine;

// Камера сверху: следует за целью со сглаживанием (SmoothDamp).
public class SmoothCameraFollow : MonoBehaviour
{
    [SerializeField] private Transform followTarget;
    [SerializeField] private Vector3 offsetFromTarget = new Vector3(0f, 12f, -4.5f);
    [SerializeField] private float smoothTime = 0.2f;

    private Vector3 currentVelocity;

    private void LateUpdate()
    {
        if (followTarget == null) return;

        Vector3 desiredPosition = followTarget.position + offsetFromTarget;
        transform.position = Vector3.SmoothDamp(
            transform.position, desiredPosition, ref currentVelocity, smoothTime);
    }
}