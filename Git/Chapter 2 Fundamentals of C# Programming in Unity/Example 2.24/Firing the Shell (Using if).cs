void HandleFiring() {
    // Check if the player pressed the Space bar.
    if (Input.GetKeyDown(KeyCode.Space)) {
    // Instantiate (create) a new shell from our prefab at the cannon’s tip.
    GameObject shell = Instantiate(shellPrefab, firePoint.position, firePoint.rotation);
    // Access the shell’s Rigidbody2D component to give it physics.
        Rigidbody2D rb = shell.GetComponent<Rigidbody2D>();
     // Now we apply the force we selected previously.
        rb.velocity = firePoint.right * fireForce;
    }
}