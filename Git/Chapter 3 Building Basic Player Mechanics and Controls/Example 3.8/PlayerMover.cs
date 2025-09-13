public class PlayerMover : MonoBehaviour
{
    public float moveSpeed = 5f;
    private Rigidbody rb;
    void Start() {
        rb = GetComponent<Rigidbody>();
    }

    void Update() {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
   Vector3 movement = new Vector3(horizontal, 0f, vertical);
        rb.linearVelocity = movement * moveSpeed;
    }
}