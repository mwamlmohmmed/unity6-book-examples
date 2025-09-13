    public int maxLives = 3;                    Example 4.11
    public int currentLives;
   public GameObject gameOverUI; // Drag your Game Over UI panel here
    public Text livesText;
    void Start()  {
        currentLives = maxLives;
        UpdateLivesUI();
        if (gameOverUI != null)
            gameOverUI.SetActive(false);
    }
    public void LoseLife()  {
        currentLives--;
        if (currentLives <= 0)  {
            TriggerGameOver();
        }
        else    {
            Respawn();
        }
        UpdateLivesUI();
    }
    void TriggerGameOver()  {
        Debug.Log("Game Over.");
        if (gameOverUI != null)
            gameOverUI.SetActive(true);
        Time.timeScale = 0f; // Optional: freeze the game
    }
    void Respawn()  {
        Debug.Log("Player respawns.");
     // Reset player health, reposition, or show animation
    }
    void UpdateLivesUI() {
        if (livesText != null)
            livesText.text = $"Lives: {currentLives}";
    }
    public void RestartLevel() {
        Time.timeScale = 1f; // Resume normal speed
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

