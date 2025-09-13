Rigidbody2D rb;
void Update() {
    float move = Input.GetAxisRaw("Horizontal");
    rb.linearVelocity = new Vector2(move * speed, rb.linearVelocity.y);
    if (move == 0) {
    rb.linearVelocity = new Vector2(0, rb.linearVelocity.y);
    }
}                