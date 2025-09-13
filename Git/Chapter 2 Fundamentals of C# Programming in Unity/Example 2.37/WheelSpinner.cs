public class WheelSpinner : MonoBehaviour {
    public Transform wheelTransform;
    public Button spinButton;
    public TextMeshProUGUI promptText;
    private bool wantsToSpinAgain = false;
    void Start() {
        spinButton.onClick.AddListener(() => StartCoroutine(SpinSequence()));
    }
    IEnumerator SpinSequence() {
        do {
            spinButton.interactable = false;
            promptText.text = "Spinning...";
               // Random final angle (0 to 360 degrees)
            float randomAngle = Random.Range(0f, 360f);
            float spinDuration = 2f;
            float elapsed = 0f;
                // Save initial rotation
            float startAngle = wheelTransform.eulerAngles.z;
                // Animate wheel spin
            while (elapsed < spinDuration) {
            float angle = Mathf.Lerp(startAngle, startAngle + 720f + randomAngle, elapsed / spinDuration);
            wheelTransform.rotation = Quaternion.Euler(0f, 0f, angle);
                elapsed += Time.deltaTime;
                yield return null;
            }
            // Final snap
         wheelTransform.rotation = Quaternion.Euler(0f, 0f, 
startAngle + 720f + randomAngle);
            // Display prompt
            promptText.text = "Spin again? Click to play!";
            wantsToSpinAgain = false;
            // Wait for player input
            spinButton.interactable = true;
            // Wait until button pressed
            while (!wantsToSpinAgain) {
                yield return null;
            }
        } while (true); // We’ll explain how to exit below
    }
    public void OnSpinAgain() {
        wantsToSpinAgain = true;
    }
