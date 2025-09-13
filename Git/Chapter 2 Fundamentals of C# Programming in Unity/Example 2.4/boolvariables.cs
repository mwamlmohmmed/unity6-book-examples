    public bool isPlayerAlive = true;
    public bool isDoorOpen = false;
    void Start()
    {
        Debug.Log("Is the player alive? " + isPlayerAlive);
        Debug.Log("Is the door open? " + isDoorOpen);

        // Now let’s change the values
        isPlayerAlive = false;
        isDoorOpen = true;
        Debug.Log("Updated player alive? " + isPlayerAlive);
        Debug.Log("Updated door open? " + isDoorOpen);
    }
