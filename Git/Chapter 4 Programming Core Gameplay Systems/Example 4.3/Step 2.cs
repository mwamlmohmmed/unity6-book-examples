private void OnTriggerEnter2D(Collider2D other) {
    if (other.CompareTag("Trap")) {
        TakeDamage(2);
        Debug.Log("Stepped on spikes!");
    }
}