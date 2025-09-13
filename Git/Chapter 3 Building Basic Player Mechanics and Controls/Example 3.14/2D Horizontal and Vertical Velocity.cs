public float moveSpeed = 5f;
    public float jumpForce = 10f;
    private Rigidbody2D rb;
    private bool isGrounded = true; // We’ll refine this later
    void Start() {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update() {
        // Get horizontal input
      float horizontalInput = Input.GetAxisRaw("Horizontal");
        // Set velocity for horizontal movement
        rb.linearVelocity = new Vector2(horizontalInput * moveSpeed, rb.linearVelocity.y);
        // Jumping logic
       if (Input.GetKeyDown(KeyCode.Space) && isGrounded) {
       rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
         isGrounded = false; // assume we left the ground
        }
    }
    void OnCollisionEnter2D(Collision2D collision) {
        // Simple ground check
        if (collision.gameObject.CompareTag("Ground")) {
            isGrounded = true;
        }
    }
