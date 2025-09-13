public class PlayerMover2D : MonoBehaviour {
    public float moveSpeed = 5f;               
    private Rigidbody2D rb;

    void Start() {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update() {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

       Vector2 movement = new Vector2(horizontal, vertical);
        rb.linearVelocity = movement * moveSpeed;
    }
}
