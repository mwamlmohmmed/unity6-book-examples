 public int maxLives = 3;                  
    public int currentLives;
    public Text livesText; // Drag in a UI Text component
    void Start() {
        currentLives = maxLives;
        UpdateLivesUI();
    }
    public void LoseLife() {
        currentLives--;
        if (currentLives <= 0) {
            TriggerGameOver();
        }
        else {
            Respawn();
        }
        UpdateLivesUI();
    }
    void UpdateLivesUI()  {
        if (livesText != null)
            livesText.text = $"Lives: {currentLives}";
    }
    void Respawn() {
        Debug.Log("Player respawns...");
       // Optional: reposition player, reset health, show animation
    }
    void TriggerGameOver() {
        Debug.Log("Game Over.");
        // Optional: show Game Over UI, freeze controls, etc.
    }
