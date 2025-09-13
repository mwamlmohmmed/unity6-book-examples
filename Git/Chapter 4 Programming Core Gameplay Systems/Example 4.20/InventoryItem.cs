using UnityEngine;
[System.Serializable]
public class InventoryItem {
    public string itemName;
    public Sprite icon;
    public int quantity = 1;
    public InventoryItem(string name, Sprite iconSprite, int initialQty = 1)  {
        itemName = name;
        icon = iconSprite;
        quantity = initialQty;
    }
}
