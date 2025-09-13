public class CoinCollector : MonoBehaviour { 
    public float collectionRadius = 1f;
    void Update() {
        GameObject[] coins = GameObject.FindGameObjectsWithTag("Coin");
        foreach (GameObject coin in coins) {
            float distance = Vector2.Distance(transform.position, coin.transform.position);
            if (distance <= collectionRadius) {
                Destroy(coin);
            }
        }
    }