public class InventoryManager : MonoBehaviour
{
    public static InventoryManager Instance;
    public List<string> collectedItems = new List<string>();
    void Awake() {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
    }
    public void AddItem(string itemName) {
        if (!collectedItems.Contains(itemName)) {
            collectedItems.Add(itemName);
            Debug.Log("Picked up: " +itemName);
        }
        else {
            Debug.Log("Already have: " +itemName);
        }
    }
    public void ShowInventory() {
        Debug.Log("Inventory:");
        foreach (string item in collectedItems) {
            Debug.Log(" - " +item);
        }
    }
}