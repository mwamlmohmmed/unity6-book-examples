using UnityEngine;
public class ItemPickup : MonoBehaviour {
    public string itemName = "Apple";
    public Sprite itemIcon;

    void OnTriggerEnter2D(Collider2D other)  {
        if (other.CompareTag("Player"))    {
            InventoryManager.Instance.AddItem(itemName, itemIcon);
            Destroy(gameObject);
        }
    }
}