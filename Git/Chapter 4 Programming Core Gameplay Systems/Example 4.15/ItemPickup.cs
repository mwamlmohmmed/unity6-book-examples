public class ItemPickup : MonoBehaviour
{
    public string itemName = "Potion";
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            InventoryManager inventory = FindAnyObjectByType<InventoryManager>();
            if (inventory != null)
            {
                inventory.AddItem(itemName);
                Destroy(gameObject); // Remove from scene
            }
        }
    }
}