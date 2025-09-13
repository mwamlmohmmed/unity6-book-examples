using TMPro; // Required to work with TextMeshPro
public class StringUIExample : MonoBehaviour
{
    public TextMeshProUGUI messageText;
    public string gameMessage = "Welcome to the game!";
    void Start()
    {
// Set the UI text to the value of gameMessage
        messageText.text = gameMessage;
// Change the message after 2 seconds for demonstration
        gameMessage = "Get ready!";
        messageText.text = gameMessage;
    }
}