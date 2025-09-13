string playerName = "";
do {
    Debug.Log("Please enter your name:");
    playerName = GetUserInput(); // Assume this fetches player input
}
while (string.IsNullOrEmpty(playerName));
Debug.Log("Welcome, " + playerName + "!");