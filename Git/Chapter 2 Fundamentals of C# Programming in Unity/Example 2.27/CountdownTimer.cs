using System.Collections;
public class CountdownTimer : MonoBehaviour {
    void Start() {
        StartCoroutine(StartCountdown());
    }
    IEnumerator StartCountdown() {
        for (int i = 10; i >= 1; i--) {
            Debug.Log("Countdown: " + i);
            yield return new WaitForSeconds(1f);
        }
        Debug.Log("Liftoff!");
    }
}       