using UnityEngine;
public enum ItemType {
    Healing,
    Buff,
    KeyItem,
    Currency,
    Equipment
}

[System.Serializable]
public class InventoryItem {
public string itemName; // What it’s called (e.g., “Health Potion”)
    public Sprite icon;// The visual icon
public string description;// A short explanation of what it does
public ItemType type;   // The category this item belongs to
public int effectValue = 0; // The power or effect of the item

    public InventoryItem(string name, Sprite sprite, string desc, ItemType itemType, int value = 0) {
        itemName = name;
        icon = sprite;
        description = desc;
        type = itemType;
        effectValue = value;
    }
}
