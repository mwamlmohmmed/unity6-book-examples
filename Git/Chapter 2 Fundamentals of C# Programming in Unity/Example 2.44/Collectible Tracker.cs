public class GemCollector : MonoBehaviour {
    private HashSet<string> collectedGems = new
HashSet<string>();
    void OnTriggerEnter2D(Collider2D other) {
        if (other.CompareTag("Gem")) {
            string gemID = other.name;

            if (collectedGems.Add(gemID)) {
                Debug.Log("Collected new gem: " +gemID);
                Destroy(other.gameObject);
            }
            else {
                Debug.Log("You already collected this gem!");
            }
        }
    }

}