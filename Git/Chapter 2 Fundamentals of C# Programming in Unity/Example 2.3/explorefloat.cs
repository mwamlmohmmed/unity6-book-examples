    public float playerSpeed = 5.5f;
    public float jumpHeight = 2.0f;
    public float musicVolume = 0.75f;
    void Start()
    {
        Debug.Log("Player Speed: " + playerSpeed);
        Debug.Log("Jump Height: " + jumpHeight);
        Debug.Log("Music Volume: " + musicVolume);

        // Change the values
        playerSpeed = 7.25f;
        musicVolume = 0.5f;
        Debug.Log("Updated Player Speed: " + playerSpeed);
        Debug.Log("Updated Music Volume: " + musicVolume);
    }