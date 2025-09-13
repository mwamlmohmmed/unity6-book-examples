 public int maxHealth = 10;               
    public int currentHealth;
    public Slider healthSlider;
    void Start()  {
        currentHealth = maxHealth;
        if (healthSlider != null)   {
            healthSlider.maxValue = maxHealth;
            healthSlider.value = currentHealth;
        }
    }
    public void TakeDamage(int amount) {
       currentHealth = Mathf.Max(currentHealth - amount, 0);
        UpdateHealthBar();
    }
    public void Heal(int amount) {
      currentHealth = Mathf.Min(currentHealth + amount, maxHealth);
        UpdateHealthBar();
    }

    void UpdateHealthBar()  {
        if (healthSlider != null)  {
            healthSlider.value = currentHealth;
        }
    }
