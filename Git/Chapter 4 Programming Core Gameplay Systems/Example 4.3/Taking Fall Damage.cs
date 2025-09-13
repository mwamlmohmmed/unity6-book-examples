public float fallThreshold = -15f; // tweak this value
private void OnCollisionEnter2D(Collision2D collision) {
    if (collision.collider.CompareTag("Ground")) {
        if (rb.velocity.y < fallThreshold) {
            int fallDamage = Mathf.RoundToInt(Mathf.Abs(rb.velocity.y) - Mathf.Abs(fallThreshold));
            TakeDamage(fallDamage);
            Debug.Log("Ouch! Landed too hard.");
        }
    }

}