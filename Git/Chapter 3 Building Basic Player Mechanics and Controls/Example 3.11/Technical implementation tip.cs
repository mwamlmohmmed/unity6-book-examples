public float acceleration = 10f;             
public float maxSpeed = 5f;
private Vector3 velocity = Vector3.zero;
void Update() {
    float horizontal = Input.GetAxis("Horizontal");
    float vertical = Input.GetAxis("Vertical");

    Vector3 targetVelocity = new Vector3(horizontal, 0, vertical) * maxSpeed;
    velocity = Vector3.Lerp(velocity, targetVelocity, acceleration * Time.deltaTime);
    transform.Translate(velocity * Time.deltaTime);
}
