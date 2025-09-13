public class ShopItemDescriptions : MonoBehaviour
{
    public TextMeshProUGUI descriptionText;
    private Dictionary<string, string> itemDescriptions;

    void Start()
    {
        itemDescriptions = new Dictionary<string, string>() {
   { "Sword", "A sharp blade. Deals high damage." },
   { "Shield", "Provides strong defense against attacks." },
   { "Potion", "Restores 50 HP when used." }
        };
        ShowDescription("Sword"); // show one by default
    }
    public void ShowDescription(string itemName)
    {
        if (itemDescriptions.ContainsKey(itemName))
        {
            descriptionText.text = itemDescriptions[itemName];
        }
        else
        {
            descriptionText.text = "Unknown item.";
        }
    }
}