public class HealthRegen : MonoBehaviour {
    public int currentHealth = 50;
    public int maxHealth = 100;
    void Start() {
        StartCoroutine(RegenerateHealth());
    }
    IEnumerator RegenerateHealth() {
        while (currentHealth < maxHealth) {
            currentHealth++;
            Debug.Log("Healing: " + currentHealth);
           yield return new WaitForSeconds(0.2f); // Add 1 HP every 0.2 seconds
        }
        Debug.Log("Fully healed!");
    }
}
