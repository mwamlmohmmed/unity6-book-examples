public int maxHealth = 5;
 public int currentHealth;
 public float drainRate = 1f; // Health drains every 1 second
 private float drainTimer;
 public Text healthText; // Drag your UI Text here in the Inspector

    void Start() {
        currentHealth = maxHealth;
        UpdateHealthUI();
    }
    void Update() {
          // Drain health over time
        drainTimer += Time.deltaTime;
        if (drainTimer >= drainRate)   {
            TakeDamage(1);
            drainTimer = 0f;
        }
    }
    public void TakeDamage(int amount)  {
        currentHealth -= amount;
        currentHealth = Mathf.Max(currentHealth, 0);
        UpdateHealthUI();
        if (currentHealth <= 0)  {
            Debug.Log("You have perished... 😵");
              // You might reload the level or freeze input here
        }
    }
    public void Heal(int amount) {
        currentHealth += amount;
        currentHealth = Mathf.Min(currentHealth, maxHealth);
        UpdateHealthUI();
    }
    void UpdateHealthUI() {
        if (healthText != null)
    healthText.text = "Health: " + currentHealth.ToString();
    }
