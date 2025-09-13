public class PlayerInventory : MonoBehaviour {
    public List<string> collectedItems = new List<string>();
    public TextMeshProUGUI inventoryText;
    void Start() {
        UpdateInventoryUI();
    }
    public void AddItem(string itemName) {
        collectedItems.Add(itemName);
        UpdateInventoryUI();
    }
    void UpdateInventoryUI() {
        inventoryText.text = "Collected Items: " + collectedItems.Count;
    }
}