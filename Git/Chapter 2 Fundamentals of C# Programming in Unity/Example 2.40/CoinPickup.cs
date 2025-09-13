public class CoinPickup : MonoBehaviour {
    public string itemName =  "Coin ";
    void OnTriggerEnter2D(Collider2D other) {
        PlayerInventory inventory = other.GetComponent<PlayerInventory>();
        if (inventory != null) {
            inventory.AddItem(itemName);
            Destroy(gameObject);
        }
    }
}