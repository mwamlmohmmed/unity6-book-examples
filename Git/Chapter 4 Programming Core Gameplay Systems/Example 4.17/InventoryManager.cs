public class InventoryManager : MonoBehaviour {
    public static InventoryManager Instance;
    public List<string> collectedItems = new List<string>();
    public TextMeshProUGUI inventoryText; // Drag from Inspector
    void Awake() {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
    }

    public void AddItem(string itemName) {
        if (!collectedItems.Contains(itemName)) {
            collectedItems.Add(itemName);
            UpdateInventoryUI();
        }
        else {
            Debug.Log($"Item ‘{ itemName}’ is already in the inventory.");
        }
    }
    void UpdateInventoryUI() {
        if (inventoryText == null) return;
        if (collectedItems.Count == 0) {
            inventoryText.text = "Inventory: (empty)";
            return;
        }
        inventoryText.text = "Inventory:\n";
        foreach (string item in collectedItems) {
            inventoryText.text += "- " +item + "\n";
        }
    }
    public void ShowInventory() {
        Debug.Log("Inventory:");
        foreach (string item in collectedItems) {
            Debug.Log(" - " +item);
        }
    }
}