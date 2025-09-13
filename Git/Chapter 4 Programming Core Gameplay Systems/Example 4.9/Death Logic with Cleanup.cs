 public int maxHealth = 5;
    public int currentHealth;
    private bool isDead = false;
    public GameObject gameOverUI; // Drag a UI panel here
    public Animator animator;     // Player death animation
    public AudioSource audioSource;
    public AudioClip deathSound;
    private PlayerController controller;

    void Awake() {
        controller = GetComponent<PlayerController>();
    }
    void Start() {
        currentHealth = maxHealth;
    }
    public void TakeDamage(int amount) {
        if (isDead) return;
        currentHealth -= amount;
        currentHealth = Mathf.Max(0, currentHealth);
        if (currentHealth <= 0)  {
            HandleDeath();
        }
    }

    void HandleDeath(){
        isDead = true;
        // 1. Disable movement
        if (controller != null)
            controller.enabled = false;
        // 2. Play animation and sound
        if (animator != null)
            animator.SetTrigger("Die");
        if (audioSource != null && deathSound != null)
            audioSource.PlayOneShot(deathSound);
        // 3. Show game over screen
        if (gameOverUI != null)
            gameOverUI.SetActive(true);
        // 4. Optional: Destroy the player object
        // Destroy(gameObject, 1.5f);
        // 5. Optional: Restart after delay
        Invoke(nameof(RestartLevel), 3f);
    }
    void RestartLevel() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
