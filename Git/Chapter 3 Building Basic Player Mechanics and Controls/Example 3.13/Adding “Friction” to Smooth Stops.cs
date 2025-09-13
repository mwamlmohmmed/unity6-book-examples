float deceleration = 20f;
Vector2 velocity = rb.linearVelocity;
if (Input.GetAxisRaw("Horizontal") == 0) {
    velocity.x = Mathf.MoveTowards(velocity.x, 0, deceleration * Time.deltaTime);
}
rb.linearVelocity = velocity;  