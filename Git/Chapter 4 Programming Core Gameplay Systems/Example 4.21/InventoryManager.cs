public void UseItem(InventoryItem item) {
    switch (item.type) {
        case ItemType.Healing:
       PlayerStats player = FindObjectOfType<PlayerStats>();
            if (player != null) {
                player.Heal(item.effectValue);
            }
            break;

        case ItemType.Buff:
            Debug.Log("Apply buff logic here later...");
            break;

        default:
            Debug.Log("This item can’t be used right now.");
            break;
    }
  items.Remove(item); // Remove item from inventory after use
  RefreshInventory(); // Update the UI
}