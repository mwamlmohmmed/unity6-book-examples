    public Transform player;                  
    public Vector2 minBounds;
    public Vector2 maxBounds;
    public float smoothSpeed = 0.15f;

    public Vector3 offset; // Keep the player slightly off-center
    void LateUpdate()   {
        Vector3 targetPos = player.position + offset;
        // Clamp the target position
        float clampedX = Mathf.Clamp(targetPos.x, minBounds.x, maxBounds.x);
        float clampedY = Mathf.Clamp(targetPos.y, minBounds.y, maxBounds.y);
        Vector3 smoothPos = Vector3.Lerp(transform.position, new Vector3(clampedX, clampedY, transform.position.z), smoothSpeed);
        transform.position = smoothPos;
    }
