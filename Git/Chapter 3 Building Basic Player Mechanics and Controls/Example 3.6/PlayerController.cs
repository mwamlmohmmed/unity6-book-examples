public class PlayerController : MonoBehaviour {
    public float moveSpeed = 5f;
    public VirtualJoystick joystick;
    private Rigidbody2D rb;
    void Start() {
        rb = GetComponent<Rigidbody2D>();
    }
    void FixedUpdate() {
        Vector2 dir = joystick.GetInputDirection();
        rb.linearVelocity = dir * moveSpeed;
    }
}
