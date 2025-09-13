 public string itemName = "Health Potion";
    public Sprite itemIcon;
    public string description = "Restores 25 health.";
    public ItemType itemType = ItemType.Healing;
    public int value = 25;
    void OnTriggerEnter2D(Collider2D other) {
        if (other.CompareTag("Player")) {
            InventoryItem newItem = new InventoryItem(itemName, itemIcon, description, itemType, value);
            InventoryManager.Instance.AddItem(newItem);
Destroy(gameObject);//gone from the world and into your inventory.
        }
    }
