   public int maxHealth = 10;
    public int currentHealth;
 public TextMeshProUGUI healthText; // Drag from Inspector
    void Start() {
        currentHealth = maxHealth;
        UpdateHealthUI();
    }
    public void TakeDamage(int damage){
        currentHealth -= damage;
        currentHealth = Mathf.Max(0, currentHealth);
        UpdateHealthUI();
    }
    public void Heal(int amount) {
        currentHealth += amount;
        currentHealth = Mathf.Min(maxHealth, currentHealth);
        UpdateHealthUI();
    }
    void UpdateHealthUI(){
        if (healthText != null)
        {
            healthText.text = $"Health: {currentHealth} / {maxHealth}";
        }
    }
