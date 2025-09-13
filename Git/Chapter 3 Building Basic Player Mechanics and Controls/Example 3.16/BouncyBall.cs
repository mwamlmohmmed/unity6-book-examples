public class BouncyBall : MonoBehaviour{
    private Rigidbody2D rb;
    void Start() {
        rb = GetComponent<Rigidbody2D>();
        rb.linearVelocity = new Vector2(3f, 8f); // Toss the ball forward and upward at start
    }
}  