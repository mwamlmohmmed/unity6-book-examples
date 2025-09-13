using UnityEngine;
using UnityEngine.UI;

public class UIInventory : MonoBehaviour {
    public static UIInventory Instance;
    public Transform gridContainer; // Parent of all item slots
    public GameObject inventorySlotPrefab;// The prefab for each item slot
    public GameObject inventoryPanel;           // Full inventory panel to show/hide

    private void Awake()  {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
    }
    private void Start()   {
        inventoryPanel.SetActive(false); // Hide by default
    }
    public void RefreshInventory() {
        foreach (Transform child in gridContainer)
            Destroy(child.gameObject);

   foreach (InventoryItem item in InventoryManager.Instance.items) {
            GameObject slot = Instantiate(inventorySlotPrefab, gridContainer);
            Image iconImage = slot.transform.GetChild(0).GetComponent<Image>();
            iconImage.sprite = item.icon;
        }
    }
    public void ToggleInventory() {
       inventoryPanel.SetActive(!inventoryPanel.activeSelf);
    }
}
