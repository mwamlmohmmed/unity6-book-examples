using UnityEngine;                       

public class TankController : MonoBehaviour {
    public Transform firePoint; // This will be the tip of our cannon.
    public GameObject shellPrefab;// Our projectile shell.
    private Camera mainCam;// Reference to the main camera.
    private float fireForce;// This will store the strength of our shot.
    void Start() {
        mainCam = Camera.main;// At the start of the game, find the main camera automatically.
        fireForce = 5f;// Let’s start with a default firing power.
    }
    void Update() {
        AimAtMouse(); // Aim our cannon at the mouse position every frame.
 HandlePowerSelection();// Check for the player’s input to select firing power.
        HandleFiring();// Check if the player fires the shell.
    }
    void AimAtMouse() {
        // Step 1: Get the mouse position on-screen and convert it to the game world.
        Vector3 mousePos = mainCam.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0f; // We set this to zero because we’re working in 2D.
        // Step 2: Calculate the direction from the tank to the mouse.
        Vector3 direction = mousePos - transform.position;
        // Step 3: Convert this direction into an angle in degrees.
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        // Finally: Rotate our tank to point at the mouse.
       transform.rotation = Quaternion.Euler(0f, 0f, angle);
    }
    void HandlePowerSelection() {
// This method will handle choosing how strong the shot is. We’ll add conditional logic here soon.
    }
    void HandleFiring() {
// This method will handle firing the shell.
  }
}
