public int currentHealth = 5;                    
public void TakeDamage(int amount) {
    currentHealth -= amount;
    currentHealth = Mathf.Max(currentHealth, 0);
    UpdateHealthUI();
    if (currentHealth <= 0) {
        HandleDeath();
    }

}