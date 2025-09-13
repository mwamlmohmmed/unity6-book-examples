public class Countdown : MonoBehaviour {        
    int counter = 5;
    void Start() {
        while (counter > 0) {
            Debug.Log("Countdown: " + counter);
            counter--;
        }
        Debug.Log("Blast off!");
    }