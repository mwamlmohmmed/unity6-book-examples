void HandlePowerSelection() {
    // Check if any key was pressed this frame.
    if (Input.anyKeyDown) {
        // Switch based on what number key was pressed.
        switch (Input.inputString) {
            case "1":
                fireForce = 10f;
                break;
            case "2":
                fireForce = 20f;
                break;
            case "3":
                fireForce = 30f;
                break;
            default:   // If any other key is pressed, do nothing.
                break;
        }
    }
}
