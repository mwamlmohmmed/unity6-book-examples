public class ItemPickup : MonoBehaviour{
    public string itemName;
    void OnTriggerEnter2D(Collider2D other)
{
    if (other.CompareTag("Player"))
    {
        InventoryManager inventory = FindObjectOfType<InventoryManager>();
        inventory.AddItem(itemName);
        Destroy(gameObject); // Item disappears
    }
}