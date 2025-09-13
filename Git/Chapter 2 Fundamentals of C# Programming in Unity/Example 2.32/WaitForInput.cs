public class WaitForInput : MonoBehaviour {
    void Start() {
        StartCoroutine(WaitForSpacebar());
    }

    IEnumerator WaitForSpacebar() {
        Debug.Log("Press Space to begin...");
        while (!Input.GetKeyDown(KeyCode.Space)) {
            yield return null; // Wait for the next frame
        }
        Debug.Log("Game Started!");
        // Now continue with game setup...
    }
}
