using UnityEngine;
public class ItemPickup : MonoBehaviour {
    public InventoryItem itemData; // Assign in Inspector
    private void OnTriggerEnter2D(Collider2D other) {
        if (other.CompareTag("Player") && itemData != null) {
            InventoryManager.Instance?.AddItem(itemData);
            Destroy(gameObject); // Remove from scene
        }
    }
}   