  public Transform player;                    
    public float smoothSpeed = 0.125f;
    public Vector3 offset;

    public float lookAheadDistance = 2f;
    public float lookAheadSpeed = 5f;

    private Vector3 currentVelocity;
    private Vector3 targetPosition;
    private Vector3 lookAheadPos;

    private float lastPlayerX;

    void Start()  {
        lastPlayerX = player.position.x;
    }
   void LateUpdate()    {
     float playerMovementX = player.position.x - lastPlayerX;
     // If the player is moving right, look ahead to the right, else left
        if (Mathf.Abs(playerMovementX) > 0.01f)  {
            lookAheadPos = new Vector3(Mathf.Sign(playerMovementX) * lookAheadDistance, 0f, 0f);
        }
        else  {
            // Ease back toward center if player stops
            lookAheadPos = Vector3.Lerp(lookAheadPos, Vector3.zero, Time.deltaTime * lookAheadSpeed);
        }
        // Final target position
        targetPosition = player.position + offset + lookAheadPos;
        // Smooth movement
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref currentVelocity, smoothSpeed);
        lastPlayerX = player.position.x;
    }