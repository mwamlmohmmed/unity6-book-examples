  public static InventoryManager Instance;   
    public List<InventoryItem> items = new List<InventoryItem>();
    void Awake() {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
    }
    public void AddItem(string itemName, Sprite icon) {
        InventoryItem existing = items.Find(i => i.itemName == itemName);    // Look for an existing stack of this item
        if (existing != null) {
            existing.quantity++;
        }
        else {
            InventoryItem newItem = new InventoryItem(itemName, icon);
            items.Add(newItem);
        }
        UIInventory.Instance.RefreshInventory();
    }
