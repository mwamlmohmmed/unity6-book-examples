void HandlePowerSelection() {
    // Let’s check if the player presses a number key to choose power.
    if (Input.GetKeyDown(KeyCode.Alpha1)) {
        fireForce = 10f; // Weak shot.
    }
    else if (Input.GetKeyDown(KeyCode.Alpha2)) {
        fireForce = 20f; // Medium shot.
    }
    else if (Input.GetKeyDown(KeyCode.Alpha3)) {
        fireForce = 30f; // Strong shot.
    }
}
