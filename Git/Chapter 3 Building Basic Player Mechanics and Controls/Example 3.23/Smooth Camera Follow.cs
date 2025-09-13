    public Transform player;                    
    public float smoothSpeed = 0.125f;
    public Vector3 offset;

    void LateUpdate()   {
        Vector3 targetPosition = player.position + offset;
        Vector3 smoothPosition = Vector3.Lerp(transform.position, targetPosition, smoothSpeed);

        transform.position = new Vector3(
            smoothPosition.x,
            smoothPosition.y,
            transform.position.z);
    }