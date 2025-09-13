    public int playerScore = 0;
    public int playerLives = 3;
    void Start()
    {
        Debug.Log("Player Score: " + playerScore);
        Debug.Log("Player Lives: " + playerLives);
        // Now let’s change the values and print them again
        playerScore = 100;
        playerLives = 1;
        Debug.Log("Updated Player Score: " + playerScore);
        Debug.Log("Updated Player Lives: " + playerLives);
    }