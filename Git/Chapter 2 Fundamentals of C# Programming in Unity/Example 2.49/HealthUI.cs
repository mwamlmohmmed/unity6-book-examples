public class HealthUI : MonoBehaviour {
    public Player player;
    void Start() {
        player.OnHealthChanged += UpdateHealthDisplay;
    }
    void UpdateHealthDisplay()  {
        Debug.Log("UI: Updating health bar...");
    }
}