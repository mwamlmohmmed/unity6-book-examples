using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour {
    public static InventoryManager Instance;  
    public List<InventoryItem> items = new List<InventoryItem>();

    private void Awake() {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
    }
    public void AddItem(InventoryItem newItem) {
        if (newItem == null) return;
        items.Add(newItem);
        UIInventory.Instance?.RefreshInventory();
    }
}
