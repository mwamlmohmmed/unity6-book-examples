public Transform player;                    
public float smoothTime = 0.3f;
private Vector3 velocity = Vector3.zero;
void LateUpdate() {
    Vector3 targetPosition = player.position;
    targetPosition.z = transform.position.z; // Keep the camera from moving in and out
    transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);
}