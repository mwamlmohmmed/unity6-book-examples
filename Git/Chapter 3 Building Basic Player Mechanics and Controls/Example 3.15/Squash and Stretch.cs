void Update(){                               
    // Example triggers
    if (Input.GetKeyDown(KeyCode.Space) && isGrounded) {
        transform.localScale = new Vector3(1.2f, 0.8f, 1f); // Squash before jump
        Invoke(nameof(ResetScale), 0.1f);
    }
    if (!isGrounded && rb.velocity.y > 0) {
        transform.localScale = new Vector3(0.8f, 1.2f, 1f); // Stretch mid-air
    }
}
void ResetScale() {
    transform.localScale = Vector3.one;
}
